
#nullable enable

namespace Mistral
{
    /// <summary>
    /// Representation of an input message inside the conversation.
    /// </summary>
    public sealed partial class MessageInputEntry
    {
        /// <summary>
        /// Default Value: entry
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        public string? Object { get; set; }

        /// <summary>
        /// Default Value: message.input
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
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Mistral.JsonConverters.MessageInputEntryRoleJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Mistral.MessageInputEntryRole Role { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Mistral.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<global::Mistral.AnyOf<global::Mistral.TextChunk, global::Mistral.ImageURLChunk, global::Mistral.ToolFileChunk, global::Mistral.DocumentURLChunk, global::Mistral.ThinkChunk>>>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Mistral.AnyOf<string, global::System.Collections.Generic.IList<global::Mistral.AnyOf<global::Mistral.TextChunk, global::Mistral.ImageURLChunk, global::Mistral.ToolFileChunk, global::Mistral.DocumentURLChunk, global::Mistral.ThinkChunk>>> Content { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prefix")]
        public bool? Prefix { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MessageInputEntry" /> class.
        /// </summary>
        /// <param name="object">
        /// Default Value: entry
        /// </param>
        /// <param name="type">
        /// Default Value: message.input
        /// </param>
        /// <param name="createdAt"></param>
        /// <param name="completedAt"></param>
        /// <param name="id"></param>
        /// <param name="role"></param>
        /// <param name="content"></param>
        /// <param name="prefix">
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MessageInputEntry(
            global::Mistral.MessageInputEntryRole role,
            global::Mistral.AnyOf<string, global::System.Collections.Generic.IList<global::Mistral.AnyOf<global::Mistral.TextChunk, global::Mistral.ImageURLChunk, global::Mistral.ToolFileChunk, global::Mistral.DocumentURLChunk, global::Mistral.ThinkChunk>>> content,
            string? @object,
            string? type,
            global::System.DateTime? createdAt,
            global::System.DateTime? completedAt,
            string? id,
            bool? prefix)
        {
            this.Role = role;
            this.Content = content;
            this.Object = @object;
            this.Type = type;
            this.CreatedAt = createdAt;
            this.CompletedAt = completedAt;
            this.Id = id;
            this.Prefix = prefix;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MessageInputEntry" /> class.
        /// </summary>
        public MessageInputEntry()
        {
        }
    }
}