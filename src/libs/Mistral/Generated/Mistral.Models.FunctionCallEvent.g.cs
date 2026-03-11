
#nullable enable

namespace Mistral
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FunctionCallEvent
    {
        /// <summary>
        /// Default Value: function.call.delta
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_index")]
        public int? OutputIndex { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public string Id { get; set; } = default!;

        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string? Model { get; set; }

        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_id")]
        public string? AgentId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public string Name { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_call_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public string ToolCallId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("arguments")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public string Arguments { get; set; } = default!;

        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("confirmation_status")]
        public global::Mistral.FunctionCallEventConfirmationStatus2? ConfirmationStatus { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FunctionCallEvent" /> class.
        /// </summary>
        /// <param name="type">
        /// Default Value: function.call.delta
        /// </param>
        /// <param name="createdAt"></param>
        /// <param name="outputIndex">
        /// Default Value: 0
        /// </param>
        /// <param name="id"></param>
        /// <param name="model">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="agentId">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="name"></param>
        /// <param name="toolCallId"></param>
        /// <param name="arguments"></param>
        /// <param name="confirmationStatus">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FunctionCallEvent(
            string id,
            string name,
            string toolCallId,
            string arguments,
            string? type,
            global::System.DateTime? createdAt,
            int? outputIndex,
            string? model,
            string? agentId,
            global::Mistral.FunctionCallEventConfirmationStatus2? confirmationStatus)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.ToolCallId = toolCallId ?? throw new global::System.ArgumentNullException(nameof(toolCallId));
            this.Arguments = arguments ?? throw new global::System.ArgumentNullException(nameof(arguments));
            this.Type = type;
            this.CreatedAt = createdAt;
            this.OutputIndex = outputIndex;
            this.Model = model;
            this.AgentId = agentId;
            this.ConfirmationStatus = confirmationStatus;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FunctionCallEvent" /> class.
        /// </summary>
        public FunctionCallEvent()
        {
        }
    }
}