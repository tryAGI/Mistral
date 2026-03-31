
#nullable enable

namespace Mistral
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WorkflowExecutionProgressTraceEvent
    {
        /// <summary>
        /// Default Value: EVENT_PROGRESS
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Mistral.JsonConverters.EventTypeJsonConverter))]
        public global::Mistral.EventType? Type { get; set; }

        /// <summary>
        /// Name of the event
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// The ID of the event
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The timestamp of the event in nanoseconds since the Unix epoch
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timestamp_unix_nano")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long TimestampUnixNano { get; set; }

        /// <summary>
        /// The attributes of the event
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("attributes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Attributes { get; set; }

        /// <summary>
        /// Whether the event is internal<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("internal")]
        public bool? Internal { get; set; }

        /// <summary>
        /// The progress message<br/>
        /// Default Value: RUNNING
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Mistral.JsonConverters.EventProgressStatusJsonConverter))]
        public global::Mistral.EventProgressStatus? Status { get; set; }

        /// <summary>
        /// The start time of the event in milliseconds since the Unix epoch
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_time_unix_ms")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long StartTimeUnixMs { get; set; }

        /// <summary>
        /// The end time of the event in milliseconds since the Unix epoch
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_time_unix_ms")]
        public long? EndTimeUnixMs { get; set; }

        /// <summary>
        /// The error message, if any
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        public string? Error { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowExecutionProgressTraceEvent" /> class.
        /// </summary>
        /// <param name="name">
        /// Name of the event
        /// </param>
        /// <param name="id">
        /// The ID of the event
        /// </param>
        /// <param name="timestampUnixNano">
        /// The timestamp of the event in nanoseconds since the Unix epoch
        /// </param>
        /// <param name="attributes">
        /// The attributes of the event
        /// </param>
        /// <param name="startTimeUnixMs">
        /// The start time of the event in milliseconds since the Unix epoch
        /// </param>
        /// <param name="type">
        /// Default Value: EVENT_PROGRESS
        /// </param>
        /// <param name="internal">
        /// Whether the event is internal<br/>
        /// Default Value: false
        /// </param>
        /// <param name="status">
        /// The progress message<br/>
        /// Default Value: RUNNING
        /// </param>
        /// <param name="endTimeUnixMs">
        /// The end time of the event in milliseconds since the Unix epoch
        /// </param>
        /// <param name="error">
        /// The error message, if any
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WorkflowExecutionProgressTraceEvent(
            string name,
            string id,
            long timestampUnixNano,
            object attributes,
            long startTimeUnixMs,
            global::Mistral.EventType? type,
            bool? @internal,
            global::Mistral.EventProgressStatus? status,
            long? endTimeUnixMs,
            string? error)
        {
            this.Type = type;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.TimestampUnixNano = timestampUnixNano;
            this.Attributes = attributes ?? throw new global::System.ArgumentNullException(nameof(attributes));
            this.Internal = @internal;
            this.Status = status;
            this.StartTimeUnixMs = startTimeUnixMs;
            this.EndTimeUnixMs = endTimeUnixMs;
            this.Error = error;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowExecutionProgressTraceEvent" /> class.
        /// </summary>
        public WorkflowExecutionProgressTraceEvent()
        {
        }
    }
}