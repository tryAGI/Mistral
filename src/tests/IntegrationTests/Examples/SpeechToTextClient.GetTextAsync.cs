/*
order: 32
title: Voxtral round-trip (TTS → Voxtral STT)
slug: voxtral-tts-stt-roundtrip

Exercises the Voxtral batch transcription endpoint end-to-end by:
1. Using Mistral TTS (`/v1/audio/speech`) to synthesize a short utterance.
2. Feeding the resulting audio bytes into
   `Meai.ISpeechToTextClient.GetTextAsync` (default model: `voxtral-mini-2507`).
3. Asserting the returned text is non-empty.

Skips when `MISTRAL_API_KEY` is unset or the account has no voices available.
*/

#pragma warning disable MEAI001 // MEAI speech-to-text abstractions are preview-gated.

using Meai = Microsoft.Extensions.AI;

namespace Mistral.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task SpeechToTextClient_GetTextAsync_TtsRoundTrip()
    {
        using var client = GetAuthenticatedClient();

        VoiceListResponse voices;
        try
        {
            voices = await client.AudioVoices.ListAllVoicesAsync();
        }
        catch (ApiException ex)
        {
            throw new AssertInconclusiveException(
                $"Mistral voice listing unavailable (HTTP {(int?)ex.StatusCode}); skipping live STT round-trip.",
                ex);
        }

        if (voices.Items is not { Count: > 0 } items)
        {
            throw new AssertInconclusiveException(
                "No voices available on this Mistral account; skipping live STT round-trip.");
        }

        var voice = items[0];

        SpeechResponse speech;
        try
        {
            speech = await client.AudioSpeech.SpeechAsync(new SpeechRequest
            {
                Input = "Hello from Voxtral.",
                VoiceId = voice.Id.ToString(),
                ResponseFormat = SpeechOutputFormat.Wav,
            });
        }
        catch (ApiException ex)
        {
            throw new AssertInconclusiveException(
                $"Mistral TTS unavailable for this account (HTTP {(int?)ex.StatusCode}); skipping live STT round-trip.",
                ex);
        }

        var audioBytes = Convert.FromBase64String(speech.AudioData);
        audioBytes.Length.Should().BeGreaterThan(0);

        Meai.ISpeechToTextClient speechClient = client;
        using var audioStream = new MemoryStream(audioBytes);
        var response = await speechClient.GetTextAsync(audioStream);

        response.Text.Should().NotBeNullOrWhiteSpace();
        response.ModelId.Should().Be(MistralClient.DefaultBatchModelId);
    }
}
