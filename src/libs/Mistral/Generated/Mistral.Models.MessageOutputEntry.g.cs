
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Mistral
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MessageOutputEntry
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_id")]
        public string? AgentId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completed_at")]
        public global::System.DateTime? CompletedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Mistral.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<global::Mistral.AnyOf<global::Mistral.TextChunk, global::Mistral.ImageURLChunk, global::Mistral.ToolFileChunk, global::Mistral.DocumentURLChunk, global::Mistral.ToolReferenceChunk>>>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Mistral.AnyOf<string, global::System.Collections.Generic.IList<global::Mistral.AnyOf<global::Mistral.TextChunk, global::Mistral.ImageURLChunk, global::Mistral.ToolFileChunk, global::Mistral.DocumentURLChunk, global::Mistral.ToolReferenceChunk>>> Content { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string? Model { get; set; }

        /// <summary>
        /// Default Value: entry
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Mistral.JsonConverters.MessageOutputEntryObjectJsonConverter))]
        public global::Mistral.MessageOutputEntryObject? Object { get; set; }

        /// <summary>
        /// Default Value: assistant
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Mistral.JsonConverters.MessageOutputEntryRoleJsonConverter))]
        public global::Mistral.MessageOutputEntryRole? Role { get; set; }

        /// <summary>
        /// Default Value: message.output
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Mistral.JsonConverters.MessageOutputEntryTypeJsonConverter))]
        public global::Mistral.MessageOutputEntryType? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MessageOutputEntry" /> class.
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="completedAt"></param>
        /// <param name="content"></param>
        /// <param name="createdAt"></param>
        /// <param name="id"></param>
        /// <param name="model"></param>
        /// <param name="object">
        /// Default Value: entry
        /// </param>
        /// <param name="role">
        /// Default Value: assistant
        /// </param>
        /// <param name="type">
        /// Default Value: message.output
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MessageOutputEntry(
            global::Mistral.AnyOf<string, global::System.Collections.Generic.IList<global::Mistral.AnyOf<global::Mistral.TextChunk, global::Mistral.ImageURLChunk, global::Mistral.ToolFileChunk, global::Mistral.DocumentURLChunk, global::Mistral.ToolReferenceChunk>>> content,
            string? agentId,
            global::System.DateTime? completedAt,
            global::System.DateTime? createdAt,
            string? id,
            string? model,
            global::Mistral.MessageOutputEntryObject? @object,
            global::Mistral.MessageOutputEntryRole? role,
            global::Mistral.MessageOutputEntryType? type)
        {
            this.Content = content;
            this.AgentId = agentId;
            this.CompletedAt = completedAt;
            this.CreatedAt = createdAt;
            this.Id = id;
            this.Model = model;
            this.Object = @object;
            this.Role = role;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MessageOutputEntry" /> class.
        /// </summary>
        public MessageOutputEntry()
        {
        }
    }
}