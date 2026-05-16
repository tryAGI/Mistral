/*
order: 31
title: Voxtral Realtime client shape
slug: voxtral-realtime-client-shape

`Mistral.Realtime.MistralRealtimeTranscriptionClient` is the WebSocket client
for `wss://api.mistral.ai/v1/audio/transcriptions/realtime?model=<id>`. It
ships with strongly-typed send methods for `session.update`,
`input_audio.append`, `input_audio.flush`, and `input_audio.end`, plus a
`ReceiveUpdatesAsync()` that yields a `ServerEvent` union covering
`transcription.language`, `transcription.segment`,
`transcription.text.delta`, `transcription.done`, `session.created`,
`session.updated`, and `error` server events.
*/

namespace Mistral.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public void Realtime_Client_CanBeConstructed()
    {
        using var realtime = new Mistral.Realtime.MistralRealtimeTranscriptionClient(apiKey: "test-key");

        realtime.IsConnected.Should().BeFalse();
        Mistral.Realtime.MistralRealtimeTranscriptionClient.DefaultBaseUrl
            .Should().Be("wss://api.mistral.ai/v1/audio/transcriptions/realtime");
    }

    [TestMethod]
    public void Realtime_ServerEvent_HasAllDiscriminators()
    {
        var ev = default(Mistral.Realtime.ServerEvent);

        ev.IsTranscriptionLanguage.Should().BeFalse();
        ev.IsTranscriptionSegment.Should().BeFalse();
        ev.IsTranscriptionTextDelta.Should().BeFalse();
        ev.IsTranscriptionDone.Should().BeFalse();
        ev.IsSessionCreated.Should().BeFalse();
        ev.IsSessionUpdated.Should().BeFalse();
        ev.IsError.Should().BeFalse();
    }
}
