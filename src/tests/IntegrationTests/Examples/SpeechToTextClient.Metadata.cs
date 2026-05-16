/*
order: 30
title: Voxtral MEAI ISpeechToTextClient
slug: voxtral-meai-speech-to-text

`MistralClient` implements `Microsoft.Extensions.AI.ISpeechToTextClient`,
backed by Voxtral. `GetTextAsync` POSTs to `/v1/audio/transcriptions`
(default model: `voxtral-mini-2507`). `GetStreamingTextAsync` opens a WebSocket
to `/v1/audio/transcriptions/realtime` (default model:
`voxtral-mini-transcribe-realtime-2602`) and yields interim + final updates.
*/

#pragma warning disable MEAI001 // MEAI speech-to-text abstractions are preview-gated.

using Meai = Microsoft.Extensions.AI;

namespace Mistral.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public void SpeechToTextClient_Metadata()
    {
        using var client = CreateTestClient();

        Meai.ISpeechToTextClient speechClient = client;

        var metadata = speechClient.GetService(typeof(Meai.SpeechToTextClientMetadata))
            as Meai.SpeechToTextClientMetadata;

        metadata.Should().NotBeNull();
        metadata!.ProviderName.Should().Be(nameof(MistralClient));

        speechClient.GetService(typeof(Meai.ISpeechToTextClient)).Should().BeSameAs(speechClient);
    }
}
