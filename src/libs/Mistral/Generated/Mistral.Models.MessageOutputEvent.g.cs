
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Mistral
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MessageOutputEvent
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_id")]
        public string? AgentId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Mistral.JsonConverters.AnyOfJsonConverter<string, global::Mistral.OutputContentChunks?>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Mistral.AnyOf<string, global::Mistral.OutputContentChunks?> Content { get; set; }

        /// <summary>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content_index")]
        public int? ContentIndex { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string? Model { get; set; }

        /// <summary>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_index")]
        public int? OutputIndex { get; set; }

        /// <summary>
        /// Default Value: assistant
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Mistral.JsonConverters.MessageOutputEventRoleJsonConverter))]
        public global::Mistral.MessageOutputEventRole? Role { get; set; }

        /// <summary>
        /// Default Value: message.output.delta
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Mistral.JsonConverters.MessageOutputEventTypeJsonConverter))]
        public global::Mistral.MessageOutputEventType? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MessageOutputEvent" /> class.
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="content"></param>
        /// <param name="contentIndex">
        /// Default Value: 0
        /// </param>
        /// <param name="createdAt"></param>
        /// <param name="id"></param>
        /// <param name="model"></param>
        /// <param name="outputIndex">
        /// Default Value: 0
        /// </param>
        /// <param name="role">
        /// Default Value: assistant
        /// </param>
        /// <param name="type">
        /// Default Value: message.output.delta
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MessageOutputEvent(
            global::Mistral.AnyOf<string, global::Mistral.OutputContentChunks?> content,
            string id,
            string? agentId,
            int? contentIndex,
            global::System.DateTime? createdAt,
            string? model,
            int? outputIndex,
            global::Mistral.MessageOutputEventRole? role,
            global::Mistral.MessageOutputEventType? type)
        {
            this.Content = content;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.AgentId = agentId;
            this.ContentIndex = contentIndex;
            this.CreatedAt = createdAt;
            this.Model = model;
            this.OutputIndex = outputIndex;
            this.Role = role;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MessageOutputEvent" /> class.
        /// </summary>
        public MessageOutputEvent()
        {
        }
    }
}