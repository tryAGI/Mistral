
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Mistral
{
    /// <summary>
    /// Representation of an input message inside the conversation.
    /// </summary>
    public sealed partial class MessageInputEntry
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completed_at")]
        public global::System.DateTime? CompletedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Mistral.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<global::Mistral.AnyOf<global::Mistral.TextChunk, global::Mistral.ImageURLChunk, global::Mistral.ToolFileChunk, global::Mistral.DocumentURLChunk>>>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Mistral.AnyOf<string, global::System.Collections.Generic.IList<global::Mistral.AnyOf<global::Mistral.TextChunk, global::Mistral.ImageURLChunk, global::Mistral.ToolFileChunk, global::Mistral.DocumentURLChunk>>> Content { get; set; }

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
        /// Default Value: entry
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Mistral.JsonConverters.MessageInputEntryObjectJsonConverter))]
        public global::Mistral.MessageInputEntryObject? Object { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prefix")]
        public bool? Prefix { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Mistral.JsonConverters.MessageInputEntryRoleJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Mistral.MessageInputEntryRole Role { get; set; }

        /// <summary>
        /// Default Value: message.input
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Mistral.JsonConverters.MessageInputEntryTypeJsonConverter))]
        public global::Mistral.MessageInputEntryType? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MessageInputEntry" /> class.
        /// </summary>
        /// <param name="completedAt"></param>
        /// <param name="content"></param>
        /// <param name="createdAt"></param>
        /// <param name="id"></param>
        /// <param name="object">
        /// Default Value: entry
        /// </param>
        /// <param name="prefix">
        /// Default Value: false
        /// </param>
        /// <param name="role"></param>
        /// <param name="type">
        /// Default Value: message.input
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MessageInputEntry(
            global::Mistral.AnyOf<string, global::System.Collections.Generic.IList<global::Mistral.AnyOf<global::Mistral.TextChunk, global::Mistral.ImageURLChunk, global::Mistral.ToolFileChunk, global::Mistral.DocumentURLChunk>>> content,
            global::Mistral.MessageInputEntryRole role,
            global::System.DateTime? completedAt,
            global::System.DateTime? createdAt,
            string? id,
            global::Mistral.MessageInputEntryObject? @object,
            bool? prefix,
            global::Mistral.MessageInputEntryType? type)
        {
            this.Content = content;
            this.Role = role;
            this.CompletedAt = completedAt;
            this.CreatedAt = createdAt;
            this.Id = id;
            this.Object = @object;
            this.Prefix = prefix;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MessageInputEntry" /> class.
        /// </summary>
        public MessageInputEntry()
        {
        }
    }
}