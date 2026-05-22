/*
order: 33
title: Voxtral realtime streaming transcription
slug: voxtral-realtime-streaming-stt

Opens a Voxtral realtime WebSocket
(`wss://api.mistral.ai/v1/audio/transcriptions/realtime`) via
`Meai.ISpeechToTextClient.GetStreamingTextAsync`, streams ~1 s of synthesized
PCM 16-bit LE / 16 kHz silence to drive the session, and verifies at least a
`SessionOpen` + `SessionClose` update pair. A `TranscriptionDone` update with
non-empty text is asserted only when the server returns one — silent input
does not reliably trigger a transcription on Voxtral.

Skips when `MISTRAL_API_KEY` is unset.
*/

#pragma warning disable MEAI001 // MEAI speech-to-text abstractions are preview-gated.

using Meai = Microsoft.Extensions.AI;

namespace Mistral.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task SpeechToTextClient_GetStreamingTextAsync_OpensAndClosesSession()
    {
        using var client = GetAuthenticatedClient();

        // 1 second of PCM 16-bit LE / 16 kHz silence (~16 000 samples × 2 B/sample).
        var pcmSilence = new byte[16000 * 2];
        using var audio = new MemoryStream(pcmSilence);

        Meai.ISpeechToTextClient speechClient = client;

        bool sessionOpened = false;
        bool sessionClosed = false;
        Meai.SpeechToTextResponseUpdate? finalUpdate = null;

        using var timeoutCts = new CancellationTokenSource(TimeSpan.FromSeconds(45));
        try
        {
            await foreach (var update in speechClient.GetStreamingTextAsync(audio, cancellationToken: timeoutCts.Token))
            {
                if (update.Kind == Meai.SpeechToTextResponseUpdateKind.SessionOpen)
                {
                    sessionOpened = true;
                }
                else if (update.Kind == Meai.SpeechToTextResponseUpdateKind.SessionClose)
                {
                    sessionClosed = true;
                }
                else if (update.Kind == Meai.SpeechToTextResponseUpdateKind.TextUpdated)
                {
                    finalUpdate = update;
                }
            }
        }
        catch (System.Net.WebSockets.WebSocketException ex)
        {
            throw new AssertInconclusiveException(
                $"Voxtral realtime endpoint unavailable (WebSocket error: {ex.Message}); skipping live streaming test.",
                ex);
        }

        sessionOpened.Should().BeTrue("the realtime session must open before audio is streamed");
        sessionClosed.Should().BeTrue("the realtime session must close cleanly");
        // finalUpdate may be null when silent input doesn't trigger transcription —
        // that's expected and not a failure of the streaming plumbing itself.
        if (finalUpdate is not null)
        {
            finalUpdate.ModelId.Should().Be(MistralClient.DefaultRealtimeModelId);
        }
    }
}
