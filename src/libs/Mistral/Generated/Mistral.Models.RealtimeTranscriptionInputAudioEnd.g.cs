
#nullable enable

namespace Mistral
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RealtimeTranscriptionInputAudioEnd
    {
        /// <summary>
        /// Default Value: input_audio.end
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeTranscriptionInputAudioEnd" /> class.
        /// </summary>
        /// <param name="type">
        /// Default Value: input_audio.end
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RealtimeTranscriptionInputAudioEnd(
            string? type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeTranscriptionInputAudioEnd" /> class.
        /// </summary>
        public RealtimeTranscriptionInputAudioEnd()
        {
        }
    }
}