
#nullable enable

namespace Mistral
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AgentHandoffDoneEvent
    {
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
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_index")]
        public int? OutputIndex { get; set; }

        /// <summary>
        /// Default Value: agent.handoff.done
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Mistral.JsonConverters.AgentHandoffDoneEventTypeJsonConverter))]
        public global::Mistral.AgentHandoffDoneEventType? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentHandoffDoneEvent" /> class.
        /// </summary>
        /// <param name="createdAt"></param>
        /// <param name="id"></param>
        /// <param name="nextAgentId"></param>
        /// <param name="nextAgentName"></param>
        /// <param name="outputIndex">
        /// Default Value: 0
        /// </param>
        /// <param name="type">
        /// Default Value: agent.handoff.done
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentHandoffDoneEvent(
            string id,
            string nextAgentId,
            string nextAgentName,
            global::System.DateTime? createdAt,
            int? outputIndex,
            global::Mistral.AgentHandoffDoneEventType? type)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.NextAgentId = nextAgentId ?? throw new global::System.ArgumentNullException(nameof(nextAgentId));
            this.NextAgentName = nextAgentName ?? throw new global::System.ArgumentNullException(nameof(nextAgentName));
            this.CreatedAt = createdAt;
            this.OutputIndex = outputIndex;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentHandoffDoneEvent" /> class.
        /// </summary>
        public AgentHandoffDoneEvent()
        {
        }
    }
}