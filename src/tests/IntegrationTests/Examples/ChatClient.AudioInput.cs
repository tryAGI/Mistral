/*
order: 34
title: Voxtral chat with audio input
slug: voxtral-chat-with-audio-input

Exercises the audio-input branch of `MistralClient.IChatClient` end-to-end by:
1. Using Mistral TTS (`/v1/audio/speech`) to synthesize a short utterance.
2. Sending that audio to a Voxtral chat model (default
   `voxtral-small-latest`) as a `Meai.DataContent` with media type
   `audio/wav`, alongside a text prompt asking the model to repeat what it
   heard.
3. Asserting the model returns text that mentions the original utterance.

Skips when `MISTRAL_API_KEY` is unset, the account has no voices, the TTS
endpoint refuses the request, or the Voxtral chat model isn't enabled for
this account.
*/

using Meai = Microsoft.Extensions.AI;

namespace Mistral.IntegrationTests;

public partial class Tests
{
    private const string VoxtralChatModelId = VoxtralModels.SmallChat;

    [TestMethod]
    public async Task ChatClient_AudioInput_VoxtralRoundTrip()
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
                $"Mistral voice listing unavailable (HTTP {(int?)ex.StatusCode}); skipping live chat-with-audio test.",
                ex);
        }

        if (voices.Items is not { Count: > 0 } items)
        {
            throw new AssertInconclusiveException(
                "No voices available on this Mistral account; skipping live chat-with-audio test.");
        }

        const string utterance = "The quick brown fox jumps over the lazy dog.";

        SpeechResponse speech;
        try
        {
            speech = await client.AudioSpeech.SpeechAsync(new SpeechRequest
            {
                Input = utterance,
                VoiceId = items[0].Id.ToString(),
                ResponseFormat = SpeechOutputFormat.Wav,
            });
        }
        catch (ApiException ex)
        {
            throw new AssertInconclusiveException(
                $"Mistral TTS unavailable for this account (HTTP {(int?)ex.StatusCode}); skipping live chat-with-audio test.",
                ex);
        }

        var audioBytes = Convert.FromBase64String(speech.AudioData);
        audioBytes.Length.Should().BeGreaterThan(0);

        Meai.IChatClient chatClient = client;
        Meai.ChatResponse response;
        try
        {
            response = await chatClient.GetResponseAsync(
                [
                    new Meai.ChatMessage(Meai.ChatRole.User,
                    [
                        new Meai.TextContent("Repeat exactly what the speaker said in the audio, with no extra commentary."),
                        new Meai.DataContent(audioBytes, mediaType: "audio/wav"),
                    ]),
                ],
                new Meai.ChatOptions
                {
                    ModelId = VoxtralChatModelId,
                });
        }
        catch (ApiException ex) when (ex.StatusCode is System.Net.HttpStatusCode.NotFound
                                          or System.Net.HttpStatusCode.Forbidden
                                          or System.Net.HttpStatusCode.BadRequest)
        {
            throw new AssertInconclusiveException(
                $"Voxtral chat model '{VoxtralChatModelId}' not enabled for this account (HTTP {(int?)ex.StatusCode}); skipping live chat-with-audio test.",
                ex);
        }

        response.Text.Should().NotBeNullOrWhiteSpace();
        response.Text.Should().ContainAny("fox", "quick", "lazy", "dog");
    }
}
