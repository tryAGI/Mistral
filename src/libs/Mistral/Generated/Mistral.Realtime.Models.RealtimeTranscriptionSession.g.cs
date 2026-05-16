
#nullable enable

namespace Mistral.Realtime
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RealtimeTranscriptionSession
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RequestId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio_format")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Mistral.Realtime.AudioFormat AudioFormat { get; set; }

        /// <summary>
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
        /// Initializes a new instance of the <see cref="RealtimeTranscriptionSession" /> class.
        /// </summary>
        /// <param name="requestId"></param>
        /// <param name="model"></param>
        /// <param name="audioFormat"></param>
        /// <param name="targetStreamingDelayMs">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RealtimeTranscriptionSession(
            string requestId,
            string model,
            global::Mistral.Realtime.AudioFormat audioFormat,
            int? targetStreamingDelayMs)
        {
            this.RequestId = requestId ?? throw new global::System.ArgumentNullException(nameof(requestId));
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.AudioFormat = audioFormat ?? throw new global::System.ArgumentNullException(nameof(audioFormat));
            this.TargetStreamingDelayMs = targetStreamingDelayMs;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeTranscriptionSession" /> class.
        /// </summary>
        public RealtimeTranscriptionSession()
        {
        }

    }
}