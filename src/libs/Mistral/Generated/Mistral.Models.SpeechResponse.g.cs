
#nullable enable

namespace Mistral
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SpeechResponse
    {
        /// <summary>
        /// Base64 encoded audio data
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
        /// Initializes a new instance of the <see cref="SpeechResponse" /> class.
        /// </summary>
        /// <param name="audioData">
        /// Base64 encoded audio data
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SpeechResponse(
            string audioData)
        {
            this.AudioData = audioData ?? throw new global::System.ArgumentNullException(nameof(audioData));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SpeechResponse" /> class.
        /// </summary>
        public SpeechResponse()
        {
        }
    }
}