
#nullable enable

namespace Mistral.Realtime
{
    public sealed partial class MistralRealtimeTranscriptionClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="message">The message to send.</param>
        /// <param name="cancellationToken">A cancellation token.</param>
        public async global::System.Threading.Tasks.Task SendRealtimeTranscriptionInputAudioAppendAsync(
            global::Mistral.Realtime.RealtimeTranscriptionInputAudioAppend message,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            message = message ?? throw new global::System.ArgumentNullException(nameof(message));

            var json = global::System.Text.Json.JsonSerializer.Serialize(message, typeof(global::Mistral.Realtime.RealtimeTranscriptionInputAudioAppend), JsonSerializerContext);

            await SendAsync(json, cancellationToken).ConfigureAwait(false);
        }


        /// <summary>
        /// Base64-encoded raw PCM bytes matching the current audio_format. Max decoded size: 262144 bytes.
        /// </summary>
        /// <param name="audio">The binary payload to send.</param>
        /// <param name="type"></param>
        /// <param name="cancellationToken">A cancellation token.</param>
        public global::System.Threading.Tasks.Task SendRealtimeTranscriptionInputAudioAppendAsync(
            global::System.ReadOnlyMemory<byte> audio,
            string? type = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            return SendRealtimeTranscriptionInputAudioAppendAsync(
                new global::Mistral.Realtime.RealtimeTranscriptionInputAudioAppend
                {
                Audio = global::System.Convert.ToBase64String(audio.Span),
                Type = type,
                },
                cancellationToken);
        }
    }
}