
#nullable enable

namespace Mistral
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RealtimeTranscriptionSessionUpdatePayload
    {
        /// <summary>
        /// Set before sending audio. Audio format updates are rejected after audio starts.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio_format")]
        public global::Mistral.AudioFormat? AudioFormat { get; set; }

        /// <summary>
        /// Set before sending audio. Streaming delay updates are rejected after audio starts.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("target_streaming_delay_ms")]
        public int? TargetStreamingDelayMs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeTranscriptionSessionUpdatePayload" /> class.
        /// </summary>
        /// <param name="audioFormat">
        /// Set before sending audio. Audio format updates are rejected after audio starts.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="targetStreamingDelayMs">
        /// Set before sending audio. Streaming delay updates are rejected after audio starts.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RealtimeTranscriptionSessionUpdatePayload(
            global::Mistral.AudioFormat? audioFormat,
            int? targetStreamingDelayMs)
        {
            this.AudioFormat = audioFormat;
            this.TargetStreamingDelayMs = targetStreamingDelayMs;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeTranscriptionSessionUpdatePayload" /> class.
        /// </summary>
        public RealtimeTranscriptionSessionUpdatePayload()
        {
        }
    }
}