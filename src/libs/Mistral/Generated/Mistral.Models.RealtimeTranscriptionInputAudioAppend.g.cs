
#nullable enable

namespace Mistral
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RealtimeTranscriptionInputAudioAppend
    {
        /// <summary>
        /// Default Value: input_audio.append
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// Base64-encoded raw PCM bytes matching the current audio_format. Max decoded size: 262144 bytes.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Audio { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeTranscriptionInputAudioAppend" /> class.
        /// </summary>
        /// <param name="type">
        /// Default Value: input_audio.append
        /// </param>
        /// <param name="audio">
        /// Base64-encoded raw PCM bytes matching the current audio_format. Max decoded size: 262144 bytes.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RealtimeTranscriptionInputAudioAppend(
            string audio,
            string? type)
        {
            this.Audio = audio ?? throw new global::System.ArgumentNullException(nameof(audio));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeTranscriptionInputAudioAppend" /> class.
        /// </summary>
        public RealtimeTranscriptionInputAudioAppend()
        {
        }
    }
}