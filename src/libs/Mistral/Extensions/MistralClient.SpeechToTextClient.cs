#nullable enable
#pragma warning disable MEAI001 // MEAI speech-to-text abstractions are preview-gated; opt in.

using System.Runtime.CompilerServices;
using Meai = Microsoft.Extensions.AI;

namespace Mistral;

/// <summary>
/// Implements <see cref="Meai.ISpeechToTextClient"/> on <see cref="MistralClient"/> via Voxtral.
/// <para>
/// <c>GetTextAsync</c> reads the full audio stream and POSTs it to
/// <c>/v1/audio/transcriptions</c> (Voxtral Mini Transcribe — batch).
/// </para>
/// <para>
/// <c>GetStreamingTextAsync</c> opens a Voxtral Realtime WebSocket
/// (<c>wss://api.mistral.ai/v1/audio/transcriptions/realtime?model=&lt;id&gt;</c>),
/// pumps the audio stream in 16 KiB PCM chunks, and yields
/// <c>transcription.text.delta</c> / <c>transcription.done</c> events as MEAI
/// updates. The caller is responsible for providing PCM-encoded audio matching
/// the <c>audio_format</c> session configuration (default: 16 kHz PCM 16-bit LE).
/// </para>
/// </summary>
public partial class MistralClient : Meai.ISpeechToTextClient
{
    private Meai.SpeechToTextClientMetadata? _speechMetadata;

    private const string DefaultBatchModelId = "voxtral-mini-2507";
    private const string DefaultRealtimeModelId = "voxtral-mini-transcribe-realtime-2602";

    /// <inheritdoc />
    object? Meai.ISpeechToTextClient.GetService(Type serviceType, object? serviceKey)
    {
        ArgumentNullException.ThrowIfNull(serviceType);

        if (serviceKey is not null)
        {
            return null;
        }

        if (serviceType == typeof(Meai.SpeechToTextClientMetadata))
        {
            return _speechMetadata ??= new(nameof(MistralClient), BaseUri);
        }

        return serviceType.IsInstanceOfType(this) ? this : null;
    }

    /// <inheritdoc />
    async Task<Meai.SpeechToTextResponse> Meai.ISpeechToTextClient.GetTextAsync(
        Stream audioSpeechStream,
        Meai.SpeechToTextOptions? options,
        CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(audioSpeechStream);

        var modelId = options?.ModelId is { Length: > 0 } id ? id : DefaultBatchModelId;

        using var memoryStream = new MemoryStream();
        await audioSpeechStream.CopyToAsync(memoryStream, cancellationToken).ConfigureAwait(false);
        var audioBytes = memoryStream.ToArray();

        var response = await AudioTranscriptions.CreateTranscriptionAsync(
            model: modelId,
            file: audioBytes,
            filename: "audio",
            language: options?.SpeechLanguage,
            cancellationToken: cancellationToken).ConfigureAwait(false);

        return new Meai.SpeechToTextResponse(response.Text)
        {
            ResponseId = null,
            ModelId = response.Model,
            RawRepresentation = response,
        };
    }

    /// <inheritdoc />
    async IAsyncEnumerable<Meai.SpeechToTextResponseUpdate> Meai.ISpeechToTextClient.GetStreamingTextAsync(
        Stream audioSpeechStream,
        Meai.SpeechToTextOptions? options,
        [EnumeratorCancellation] CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(audioSpeechStream);

        var apiKey = ResolveBearerApiKey()
            ?? throw new InvalidOperationException(
                "No Mistral API key found on the client. Construct MistralClient with a Bearer token before calling GetStreamingTextAsync.");

        var modelId = options?.ModelId is { Length: > 0 } id ? id : DefaultRealtimeModelId;
        var sampleRate = options?.SpeechSampleRate is int rate and > 0 ? rate : 16000;

        var realtime = new Realtime.MistralRealtimeTranscriptionClient(apiKey);
        await using (realtime.ConfigureAwait(false))
        {
            await realtime.ConnectAsync(
                model: modelId,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            await realtime.SendRealtimeTranscriptionSessionUpdateMessageAsync(
                new Realtime.RealtimeTranscriptionSessionUpdateMessage
                {
                    Session = new Realtime.RealtimeTranscriptionSessionUpdatePayload
                    {
                        AudioFormat = new Realtime.AudioFormat
                        {
                            Encoding = Realtime.AudioEncoding.PcmS16le,
                            SampleRate = sampleRate,
                        },
                    },
                },
                cancellationToken: cancellationToken).ConfigureAwait(false);

            var responseId = Guid.NewGuid().ToString("N");
            yield return new Meai.SpeechToTextResponseUpdate
            {
                Kind = Meai.SpeechToTextResponseUpdateKind.SessionOpen,
                ResponseId = responseId,
                ModelId = modelId,
            };

            var sendTask = Task.Run(async () =>
            {
                try
                {
                    // Mistral caps each input_audio.append at 262144 decoded bytes;
                    // stay well under that to keep latency low.
                    var buffer = new byte[16 * 1024];
                    int bytesRead;
                    while ((bytesRead = await audioSpeechStream.ReadAsync(
                        buffer.AsMemory(0, buffer.Length),
                        cancellationToken).ConfigureAwait(false)) > 0)
                    {
                        await realtime.SendRealtimeTranscriptionInputAudioAppendAsync(
                            audio: buffer.AsMemory(0, bytesRead),
                            cancellationToken: cancellationToken).ConfigureAwait(false);
                    }

                    await realtime.SendRealtimeTranscriptionInputAudioFlushAsync(
                        new Realtime.RealtimeTranscriptionInputAudioFlush(),
                        cancellationToken: cancellationToken).ConfigureAwait(false);
                    await realtime.SendRealtimeTranscriptionInputAudioEndAsync(
                        new Realtime.RealtimeTranscriptionInputAudioEnd(),
                        cancellationToken: cancellationToken).ConfigureAwait(false);
                }
                catch (OperationCanceledException)
                {
                }
            }, cancellationToken);

            await foreach (var @event in realtime.ReceiveUpdatesAsync(cancellationToken).ConfigureAwait(false))
            {
                if (@event.IsTranscriptionTextDelta && @event.TranscriptionTextDelta is { } delta)
                {
                    yield return new Meai.SpeechToTextResponseUpdate(delta.Text)
                    {
                        Kind = Meai.SpeechToTextResponseUpdateKind.TextUpdating,
                        ResponseId = responseId,
                        ModelId = modelId,
                        RawRepresentation = delta,
                    };
                }
                else if (@event.IsTranscriptionDone && @event.TranscriptionDone is { } done)
                {
                    yield return new Meai.SpeechToTextResponseUpdate(done.Text)
                    {
                        Kind = Meai.SpeechToTextResponseUpdateKind.TextUpdated,
                        ResponseId = responseId,
                        ModelId = modelId,
                        RawRepresentation = done,
                    };
                    break;
                }
                else if (@event.IsError)
                {
                    yield return new Meai.SpeechToTextResponseUpdate
                    {
                        Kind = Meai.SpeechToTextResponseUpdateKind.Error,
                        ResponseId = responseId,
                        ModelId = modelId,
                        RawRepresentation = @event.Error,
                    };
                    break;
                }
            }

            yield return new Meai.SpeechToTextResponseUpdate
            {
                Kind = Meai.SpeechToTextResponseUpdateKind.SessionClose,
                ResponseId = responseId,
                ModelId = modelId,
            };

            try
            {
                await sendTask.ConfigureAwait(false);
            }
            catch (OperationCanceledException)
            {
            }
        }
    }

    private string? ResolveBearerApiKey()
    {
        for (int i = 0; i < Authorizations.Count; i++)
        {
            var auth = Authorizations[i];
            if (auth is { Type: "Http", Value: { Length: > 0 } value })
            {
                return value;
            }
        }

        return null;
    }
}
