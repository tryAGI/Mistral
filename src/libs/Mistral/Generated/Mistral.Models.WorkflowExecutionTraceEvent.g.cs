
#nullable enable

namespace Mistral
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WorkflowExecutionTraceEvent
    {
        /// <summary>
        /// Default Value: EVENT
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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowExecutionTraceEvent" /> class.
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
        /// <param name="type">
        /// Default Value: EVENT
        /// </param>
        /// <param name="internal">
        /// Whether the event is internal<br/>
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WorkflowExecutionTraceEvent(
            string name,
            string id,
            long timestampUnixNano,
            object attributes,
            global::Mistral.EventType? type,
            bool? @internal)
        {
            this.Type = type;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.TimestampUnixNano = timestampUnixNano;
            this.Attributes = attributes ?? throw new global::System.ArgumentNullException(nameof(attributes));
            this.Internal = @internal;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowExecutionTraceEvent" /> class.
        /// </summary>
        public WorkflowExecutionTraceEvent()
        {
        }
    }
}