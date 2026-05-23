/*
order: 35
title: Voxtral chat with audio input (streaming)
slug: voxtral-chat-with-audio-input-streaming

Exercises the audio-input branch of `MistralClient.IChatClient` over the
streaming path:
1. Use Mistral TTS to synthesize a short utterance.
2. Stream a chat completion from `VoxtralModels.SmallChat` with the audio
   bytes attached as a `Meai.DataContent` with `audio/wav` media type.
3. Assert that the accumulated `Meai.ChatResponseUpdate.Text` mentions the
   original utterance.

Skips when `MISTRAL_API_KEY` is unset, the account has no voices, TTS refuses
the request, or the Voxtral chat model isn't enabled for this account.
*/

using Meai = Microsoft.Extensions.AI;

namespace Mistral.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task ChatClient_AudioInput_VoxtralRoundTrip_Streaming()
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
                $"Mistral voice listing unavailable (HTTP {(int?)ex.StatusCode}); skipping live streaming chat-with-audio test.",
                ex);
        }

        if (voices.Items is not { Count: > 0 } items)
        {
            throw new AssertInconclusiveException(
                "No voices available on this Mistral account; skipping live streaming chat-with-audio test.");
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
                $"Mistral TTS unavailable for this account (HTTP {(int?)ex.StatusCode}); skipping live streaming chat-with-audio test.",
                ex);
        }

        var audioBytes = Convert.FromBase64String(speech.AudioData);
        audioBytes.Length.Should().BeGreaterThan(0);

        Meai.IChatClient chatClient = client;
        var updates = chatClient.GetStreamingResponseAsync(
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

        var deltas = new List<string>();
        try
        {
            await foreach (var update in updates)
            {
                if (!string.IsNullOrEmpty(update.Text))
                {
                    deltas.Add(update.Text);
                }
            }
        }
        catch (ApiException ex) when (ex.StatusCode is System.Net.HttpStatusCode.NotFound
                                          or System.Net.HttpStatusCode.Forbidden
                                          or System.Net.HttpStatusCode.BadRequest)
        {
            throw new AssertInconclusiveException(
                $"Voxtral chat model '{VoxtralChatModelId}' not enabled for this account (HTTP {(int?)ex.StatusCode}); skipping live streaming chat-with-audio test.",
                ex);
        }

        deltas.Should().NotBeEmpty();
        var combined = string.Concat(deltas);
        combined.Should().NotBeNullOrWhiteSpace();
        combined.Should().ContainAny("fox", "quick", "lazy", "dog");
    }
}
