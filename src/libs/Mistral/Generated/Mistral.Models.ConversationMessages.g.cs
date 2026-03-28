
#nullable enable

namespace Mistral
{
    /// <summary>
    /// Similar to the conversation history but only keep the messages
    /// </summary>
    public sealed partial class ConversationMessages
    {
        /// <summary>
        /// Default Value: conversation.messages
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        public string? Object { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("conversation_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ConversationId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("messages")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Mistral.AnyOf<global::Mistral.MessageInputEntry, global::Mistral.MessageOutputEntry>> Messages { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationMessages" /> class.
        /// </summary>
        /// <param name="object">
        /// Default Value: conversation.messages
        /// </param>
        /// <param name="conversationId"></param>
        /// <param name="messages"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ConversationMessages(
            string conversationId,
            global::System.Collections.Generic.IList<global::Mistral.AnyOf<global::Mistral.MessageInputEntry, global::Mistral.MessageOutputEntry>> messages,
            string? @object)
        {
            this.ConversationId = conversationId ?? throw new global::System.ArgumentNullException(nameof(conversationId));
            this.Messages = messages ?? throw new global::System.ArgumentNullException(nameof(messages));
            this.Object = @object;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationMessages" /> class.
        /// </summary>
        public ConversationMessages()
        {
        }
    }
}