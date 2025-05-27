
#nullable enable

namespace Mistral
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AgentHandoffStartedEvent
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
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_index")]
        public int? OutputIndex { get; set; }

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
        /// Default Value: agent.handoff.started
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Mistral.JsonConverters.AgentHandoffStartedEventTypeJsonConverter))]
        public global::Mistral.AgentHandoffStartedEventType? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentHandoffStartedEvent" /> class.
        /// </summary>
        /// <param name="createdAt"></param>
        /// <param name="id"></param>
        /// <param name="outputIndex">
        /// Default Value: 0
        /// </param>
        /// <param name="previousAgentId"></param>
        /// <param name="previousAgentName"></param>
        /// <param name="type">
        /// Default Value: agent.handoff.started
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentHandoffStartedEvent(
            string id,
            string previousAgentId,
            string previousAgentName,
            global::System.DateTime? createdAt,
            int? outputIndex,
            global::Mistral.AgentHandoffStartedEventType? type)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.PreviousAgentId = previousAgentId ?? throw new global::System.ArgumentNullException(nameof(previousAgentId));
            this.PreviousAgentName = previousAgentName ?? throw new global::System.ArgumentNullException(nameof(previousAgentName));
            this.CreatedAt = createdAt;
            this.OutputIndex = outputIndex;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentHandoffStartedEvent" /> class.
        /// </summary>
        public AgentHandoffStartedEvent()
        {
        }
    }
}