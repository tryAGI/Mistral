
#nullable enable

namespace Mistral
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AgentHandoffEntry
    {
        /// <summary>
        /// Default Value: entry
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        public string? Object { get; set; }

        /// <summary>
        /// Default Value: agent.handoff
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
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("previous_agent_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PreviousAgentId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("previous_agent_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PreviousAgentName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("next_agent_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string NextAgentId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("next_agent_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string NextAgentName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentHandoffEntry" /> class.
        /// </summary>
        /// <param name="previousAgentId"></param>
        /// <param name="previousAgentName"></param>
        /// <param name="nextAgentId"></param>
        /// <param name="nextAgentName"></param>
        /// <param name="object">
        /// Default Value: entry
        /// </param>
        /// <param name="type">
        /// Default Value: agent.handoff
        /// </param>
        /// <param name="createdAt"></param>
        /// <param name="completedAt"></param>
        /// <param name="id"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentHandoffEntry(
            string previousAgentId,
            string previousAgentName,
            string nextAgentId,
            string nextAgentName,
            string? @object,
            string? type,
            global::System.DateTime? createdAt,
            global::System.DateTime? completedAt,
            string? id)
        {
            this.Object = @object;
            this.Type = type;
            this.CreatedAt = createdAt;
            this.CompletedAt = completedAt;
            this.Id = id;
            this.PreviousAgentId = previousAgentId ?? throw new global::System.ArgumentNullException(nameof(previousAgentId));
            this.PreviousAgentName = previousAgentName ?? throw new global::System.ArgumentNullException(nameof(previousAgentName));
            this.NextAgentId = nextAgentId ?? throw new global::System.ArgumentNullException(nameof(nextAgentId));
            this.NextAgentName = nextAgentName ?? throw new global::System.ArgumentNullException(nameof(nextAgentName));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentHandoffEntry" /> class.
        /// </summary>
        public AgentHandoffEntry()
        {
        }
    }
}