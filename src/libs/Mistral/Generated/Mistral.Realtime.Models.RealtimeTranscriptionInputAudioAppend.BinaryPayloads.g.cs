
#nullable enable

namespace Mistral.Realtime
{
    public sealed partial class RealtimeTranscriptionInputAudioAppend
    {
        /// <summary>
        /// Gets the decoded bytes for <see cref="Audio" />.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonIgnore]
        public global::System.ReadOnlyMemory<byte> AudioBytes => Audio is null
            ? default
            : global::System.Convert.FromBase64String(Audio);
    }
}