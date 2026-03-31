
#nullable enable

namespace Mistral
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class StreamV1WorkflowsExecutionsExecutionIdStreamGetResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("event")]
        public string? Event { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        public global::Mistral.StreamEventSsePayload? Data { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("retry")]
        public int? Retry { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StreamV1WorkflowsExecutionsExecutionIdStreamGetResponse" /> class.
        /// </summary>
        /// <param name="event"></param>
        /// <param name="data"></param>
        /// <param name="id"></param>
        /// <param name="retry"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public StreamV1WorkflowsExecutionsExecutionIdStreamGetResponse(
            string? @event,
            global::Mistral.StreamEventSsePayload? data,
            string? id,
            int? retry)
        {
            this.Event = @event;
            this.Data = data;
            this.Id = id;
            this.Retry = retry;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StreamV1WorkflowsExecutionsExecutionIdStreamGetResponse" /> class.
        /// </summary>
        public StreamV1WorkflowsExecutionsExecutionIdStreamGetResponse()
        {
        }
    }
}