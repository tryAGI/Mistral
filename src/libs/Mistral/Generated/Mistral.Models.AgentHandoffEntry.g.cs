
#nullable enable

namespace Mistral
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AgentHandoffEntry
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completed_at")]
        public global::System.DateTime? CompletedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

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
        /// Default Value: entry
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Mistral.JsonConverters.AgentHandoffEntryObjectJsonConverter))]
        public global::Mistral.AgentHandoffEntryObject? Object { get; set; }

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
        /// Default Value: agent.handoff
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Mistral.JsonConverters.AgentHandoffEntryTypeJsonConverter))]
        public global::Mistral.AgentHandoffEntryType? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentHandoffEntry" /> class.
        /// </summary>
        /// <param name="completedAt"></param>
        /// <param name="createdAt"></param>
        /// <param name="id"></param>
        /// <param name="nextAgentId"></param>
        /// <param name="nextAgentName"></param>
        /// <param name="object">
        /// Default Value: entry
        /// </param>
        /// <param name="previousAgentId"></param>
        /// <param name="previousAgentName"></param>
        /// <param name="type">
        /// Default Value: agent.handoff
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentHandoffEntry(
            string nextAgentId,
            string nextAgentName,
            string previousAgentId,
            string previousAgentName,
            global::System.DateTime? completedAt,
            global::System.DateTime? createdAt,
            string? id,
            global::Mistral.AgentHandoffEntryObject? @object,
            global::Mistral.AgentHandoffEntryType? type)
        {
            this.NextAgentId = nextAgentId ?? throw new global::System.ArgumentNullException(nameof(nextAgentId));
            this.NextAgentName = nextAgentName ?? throw new global::System.ArgumentNullException(nameof(nextAgentName));
            this.PreviousAgentId = previousAgentId ?? throw new global::System.ArgumentNullException(nameof(previousAgentId));
            this.PreviousAgentName = previousAgentName ?? throw new global::System.ArgumentNullException(nameof(previousAgentName));
            this.CompletedAt = completedAt;
            this.CreatedAt = createdAt;
            this.Id = id;
            this.Object = @object;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentHandoffEntry" /> class.
        /// </summary>
        public AgentHandoffEntry()
        {
        }
    }
}