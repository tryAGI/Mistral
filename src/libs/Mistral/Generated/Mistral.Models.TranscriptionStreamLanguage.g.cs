
#nullable enable

namespace Mistral
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TranscriptionStreamLanguage
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio_language")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AudioLanguage { get; set; }

        /// <summary>
        /// Default Value: transcription.language
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Mistral.JsonConverters.TranscriptionStreamLanguageTypeJsonConverter))]
        public global::Mistral.TranscriptionStreamLanguageType? Type { get; set; }

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
            global::Mistral.TranscriptionStreamLanguageType? type)
        {
            this.AudioLanguage = audioLanguage ?? throw new global::System.ArgumentNullException(nameof(audioLanguage));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TranscriptionStreamLanguage" /> class.
        /// </summary>
        public TranscriptionStreamLanguage()
        {
        }
    }
}