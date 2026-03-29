
#nullable enable

namespace Mistral
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SpeechStreamAudioDelta
    {
        /// <summary>
        /// Default Value: speech.audio.delta
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio_data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AudioData { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SpeechStreamAudioDelta" /> class.
        /// </summary>
        /// <param name="audioData"></param>
        /// <param name="type">
        /// Default Value: speech.audio.delta
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SpeechStreamAudioDelta(
            string audioData,
            string? type)
        {
            this.Type = type;
            this.AudioData = audioData ?? throw new global::System.ArgumentNullException(nameof(audioData));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SpeechStreamAudioDelta" /> class.
        /// </summary>
        public SpeechStreamAudioDelta()
        {
        }
    }
}