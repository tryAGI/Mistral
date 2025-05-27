
#nullable enable

namespace Mistral
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FunctionCallEvent
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("arguments")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Arguments { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_index")]
        public int? OutputIndex { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_call_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ToolCallId { get; set; }

        /// <summary>
        /// Default Value: function.call.delta
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Mistral.JsonConverters.FunctionCallEventTypeJsonConverter))]
        public global::Mistral.FunctionCallEventType? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FunctionCallEvent" /> class.
        /// </summary>
        /// <param name="arguments"></param>
        /// <param name="createdAt"></param>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="outputIndex">
        /// Default Value: 0
        /// </param>
        /// <param name="toolCallId"></param>
        /// <param name="type">
        /// Default Value: function.call.delta
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FunctionCallEvent(
            string arguments,
            string id,
            string name,
            string toolCallId,
            global::System.DateTime? createdAt,
            int? outputIndex,
            global::Mistral.FunctionCallEventType? type)
        {
            this.Arguments = arguments ?? throw new global::System.ArgumentNullException(nameof(arguments));
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.ToolCallId = toolCallId ?? throw new global::System.ArgumentNullException(nameof(toolCallId));
            this.CreatedAt = createdAt;
            this.OutputIndex = outputIndex;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FunctionCallEvent" /> class.
        /// </summary>
        public FunctionCallEvent()
        {
        }
    }
}