
#nullable enable

namespace Mistral
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ToolExecutionEntry
    {
        /// <summary>
        /// Default Value: entry
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        public string? Object { get; set; }

        /// <summary>
        /// Default Value: tool.execution
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completed_at")]
        public global::System.DateTime? CompletedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_id")]
        public string? AgentId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string? Model { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Mistral.JsonConverters.AnyOfJsonConverter<global::Mistral.BuiltInConnectors?, string>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Mistral.AnyOf<global::Mistral.BuiltInConnectors?, string> Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("arguments")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Arguments { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("info")]
        public global::Mistral.ToolExecutionInfo? Info { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolExecutionEntry" /> class.
        /// </summary>
        /// <param name="object">
        /// Default Value: entry
        /// </param>
        /// <param name="type">
        /// Default Value: tool.execution
        /// </param>
        /// <param name="createdAt"></param>
        /// <param name="completedAt"></param>
        /// <param name="agentId"></param>
        /// <param name="model"></param>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="arguments"></param>
        /// <param name="info"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ToolExecutionEntry(
            global::Mistral.AnyOf<global::Mistral.BuiltInConnectors?, string> name,
            string arguments,
            string? @object,
            string? type,
            global::System.DateTime? createdAt,
            global::System.DateTime? completedAt,
            string? agentId,
            string? model,
            string? id,
            global::Mistral.ToolExecutionInfo? info)
        {
            this.Name = name;
            this.Arguments = arguments ?? throw new global::System.ArgumentNullException(nameof(arguments));
            this.Object = @object;
            this.Type = type;
            this.CreatedAt = createdAt;
            this.CompletedAt = completedAt;
            this.AgentId = agentId;
            this.Model = model;
            this.Id = id;
            this.Info = info;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolExecutionEntry" /> class.
        /// </summary>
        public ToolExecutionEntry()
        {
        }
    }
}