#nullable enable

namespace Mistral;

/// <summary>
/// Canonical Voxtral model identifiers. Voxtral is Mistral's audio-understanding
/// model line; each constant maps to a dated snapshot id. When Mistral rotates a
/// snapshot, update the value here and every caller picks up the new id
/// automatically.
/// </summary>
/// <remarks>
/// See https://docs.mistral.ai/capabilities/audio/ for the current model catalog.
/// </remarks>
public static class VoxtralModels
{
    /// <summary>
    /// Voxtral Mini Transcribe — batch transcription via
    /// <c>POST /v1/audio/transcriptions</c>. Default model used by
    /// <see cref="Microsoft.Extensions.AI.ISpeechToTextClient"/>'s
    /// <c>GetTextAsync</c> path. Card:
    /// https://docs.mistral.ai/models/voxtral-mini-transcribe-26-02.
    /// </summary>
    public const string MiniTranscribe = "voxtral-mini-2507";

    /// <summary>
    /// Voxtral Mini Transcribe Realtime — low-latency live transcription via
    /// the WebSocket at <c>wss://api.mistral.ai/v1/audio/transcriptions/realtime</c>.
    /// Default model used by <see cref="Microsoft.Extensions.AI.ISpeechToTextClient"/>'s
    /// <c>GetStreamingTextAsync</c> path. Card:
    /// https://docs.mistral.ai/models/voxtral-mini-transcribe-realtime-26-02.
    /// </summary>
    public const string MiniTranscribeRealtime = "voxtral-mini-transcribe-realtime-2602";

    /// <summary>
    /// Voxtral Mini — audio-capable chat model exposed via
    /// <c>POST /v1/chat/completions</c>. Accepts
    /// <see cref="Microsoft.Extensions.AI.DataContent"/> with an
    /// <c>audio/*</c> media type in user messages.
    /// </summary>
    public const string MiniChat = "voxtral-mini-latest";

    /// <summary>
    /// Voxtral Small — larger audio-capable chat model exposed via
    /// <c>POST /v1/chat/completions</c>. Accepts
    /// <see cref="Microsoft.Extensions.AI.DataContent"/> with an
    /// <c>audio/*</c> media type in user messages. Card:
    /// https://docs.mistral.ai/models/voxtral-small-25-07.
    /// </summary>
    public const string SmallChat = "voxtral-small-latest";
}
