
#nullable enable

namespace Mistral
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WorkflowExecutionTraceSummarySpan
    {
        /// <summary>
        /// The ID of the span
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("span_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SpanId { get; set; }

        /// <summary>
        /// The name of the span
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// The start time of the span in nanoseconds since the Unix epoch
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_time_unix_nano")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long StartTimeUnixNano { get; set; }

        /// <summary>
        /// The end time of the span in nanoseconds since the Unix epoch
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_time_unix_nano")]
        public long? EndTimeUnixNano { get; set; }

        /// <summary>
        /// The attributes of the span
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("attributes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Attributes { get; set; }

        /// <summary>
        /// The events of the span
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("events")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Mistral.WorkflowExecutionTraceEvent> Events { get; set; }

        /// <summary>
        /// The child spans of the span
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("children")]
        public global::System.Collections.Generic.IList<global::Mistral.WorkflowExecutionTraceSummarySpan>? Children { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowExecutionTraceSummarySpan" /> class.
        /// </summary>
        /// <param name="spanId">
        /// The ID of the span
        /// </param>
        /// <param name="name">
        /// The name of the span
        /// </param>
        /// <param name="startTimeUnixNano">
        /// The start time of the span in nanoseconds since the Unix epoch
        /// </param>
        /// <param name="attributes">
        /// The attributes of the span
        /// </param>
        /// <param name="events">
        /// The events of the span
        /// </param>
        /// <param name="endTimeUnixNano">
        /// The end time of the span in nanoseconds since the Unix epoch
        /// </param>
        /// <param name="children">
        /// The child spans of the span
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WorkflowExecutionTraceSummarySpan(
            string spanId,
            string name,
            long startTimeUnixNano,
            object attributes,
            global::System.Collections.Generic.IList<global::Mistral.WorkflowExecutionTraceEvent> events,
            long? endTimeUnixNano,
            global::System.Collections.Generic.IList<global::Mistral.WorkflowExecutionTraceSummarySpan>? children)
        {
            this.SpanId = spanId ?? throw new global::System.ArgumentNullException(nameof(spanId));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.StartTimeUnixNano = startTimeUnixNano;
            this.EndTimeUnixNano = endTimeUnixNano;
            this.Attributes = attributes ?? throw new global::System.ArgumentNullException(nameof(attributes));
            this.Events = events ?? throw new global::System.ArgumentNullException(nameof(events));
            this.Children = children;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowExecutionTraceSummarySpan" /> class.
        /// </summary>
        public WorkflowExecutionTraceSummarySpan()
        {
        }
    }
}