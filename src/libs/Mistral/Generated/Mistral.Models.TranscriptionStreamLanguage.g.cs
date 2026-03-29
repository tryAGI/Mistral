
#nullable enable

namespace Mistral
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TranscriptionStreamLanguage
    {
        /// <summary>
        /// Default Value: transcription.language
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio_language")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AudioLanguage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TranscriptionStreamLanguage" /> class.
        /// </summary>
        /// <param name="audioLanguage"></param>
        /// <param name="type">
        /// Default Value: transcription.language
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TranscriptionStreamLanguage(
            string audioLanguage,
            string? type)
        {
            this.Type = type;
            this.AudioLanguage = audioLanguage ?? throw new global::System.ArgumentNullException(nameof(audioLanguage));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TranscriptionStreamLanguage" /> class.
        /// </summary>
        public TranscriptionStreamLanguage()
        {
        }
    }
}