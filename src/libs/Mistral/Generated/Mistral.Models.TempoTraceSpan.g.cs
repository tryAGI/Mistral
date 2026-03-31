
#nullable enable

namespace Mistral
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TempoTraceSpan
    {
        /// <summary>
        /// The trace ID of the scope
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("traceId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TraceId { get; set; }

        /// <summary>
        /// The span ID of the scope
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("spanId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SpanId { get; set; }

        /// <summary>
        /// The parent span ID of the scope
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parentSpanId")]
        public string? ParentSpanId { get; set; }

        /// <summary>
        /// The name of the scope
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// The kind of the scope
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("kind")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Mistral.JsonConverters.TempoTraceScopeKindJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Mistral.TempoTraceScopeKind Kind { get; set; }

        /// <summary>
        /// The start time of the scope in Unix nano
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("startTimeUnixNano")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string StartTimeUnixNano { get; set; }

        /// <summary>
        /// The end time of the scope in Unix nano
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("endTimeUnixNano")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EndTimeUnixNano { get; set; }

        /// <summary>
        /// The attributes of the scope
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("attributes")]
        public global::System.Collections.Generic.IList<global::Mistral.TempoTraceAttribute>? Attributes { get; set; }

        /// <summary>
        /// The events of the scope
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("events")]
        public global::System.Collections.Generic.IList<global::Mistral.TempoTraceEvent>? Events { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TempoTraceSpan" /> class.
        /// </summary>
        /// <param name="traceId">
        /// The trace ID of the scope
        /// </param>
        /// <param name="spanId">
        /// The span ID of the scope
        /// </param>
        /// <param name="name">
        /// The name of the scope
        /// </param>
        /// <param name="kind">
        /// The kind of the scope
        /// </param>
        /// <param name="startTimeUnixNano">
        /// The start time of the scope in Unix nano
        /// </param>
        /// <param name="endTimeUnixNano">
        /// The end time of the scope in Unix nano
        /// </param>
        /// <param name="parentSpanId">
        /// The parent span ID of the scope
        /// </param>
        /// <param name="attributes">
        /// The attributes of the scope
        /// </param>
        /// <param name="events">
        /// The events of the scope
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TempoTraceSpan(
            string traceId,
            string spanId,
            string name,
            global::Mistral.TempoTraceScopeKind kind,
            string startTimeUnixNano,
            string endTimeUnixNano,
            string? parentSpanId,
            global::System.Collections.Generic.IList<global::Mistral.TempoTraceAttribute>? attributes,
            global::System.Collections.Generic.IList<global::Mistral.TempoTraceEvent>? events)
        {
            this.TraceId = traceId ?? throw new global::System.ArgumentNullException(nameof(traceId));
            this.SpanId = spanId ?? throw new global::System.ArgumentNullException(nameof(spanId));
            this.ParentSpanId = parentSpanId;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Kind = kind;
            this.StartTimeUnixNano = startTimeUnixNano ?? throw new global::System.ArgumentNullException(nameof(startTimeUnixNano));
            this.EndTimeUnixNano = endTimeUnixNano ?? throw new global::System.ArgumentNullException(nameof(endTimeUnixNano));
            this.Attributes = attributes;
            this.Events = events;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TempoTraceSpan" /> class.
        /// </summary>
        public TempoTraceSpan()
        {
        }
    }
}