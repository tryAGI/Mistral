
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Mistral
{
    /// <summary>
    /// Retrieve all entries in a conversation.
    /// </summary>
    public sealed partial class ConversationHistory
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("conversation_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ConversationId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("entries")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Mistral.AnyOf<global::Mistral.MessageInputEntry, global::Mistral.MessageOutputEntry, global::Mistral.FunctionResultEntry, global::Mistral.FunctionCallEntry, global::Mistral.ToolExecutionEntry, global::Mistral.AgentHandoffEntry>> Entries { get; set; }

        /// <summary>
        /// Default Value: conversation.history
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Mistral.JsonConverters.ConversationHistoryObjectJsonConverter))]
        public global::Mistral.ConversationHistoryObject? Object { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationHistory" /> class.
        /// </summary>
        /// <param name="conversationId"></param>
        /// <param name="entries"></param>
        /// <param name="object">
        /// Default Value: conversation.history
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ConversationHistory(
            string conversationId,
            global::System.Collections.Generic.IList<global::Mistral.AnyOf<global::Mistral.MessageInputEntry, global::Mistral.MessageOutputEntry, global::Mistral.FunctionResultEntry, global::Mistral.FunctionCallEntry, global::Mistral.ToolExecutionEntry, global::Mistral.AgentHandoffEntry>> entries,
            global::Mistral.ConversationHistoryObject? @object)
        {
            this.ConversationId = conversationId ?? throw new global::System.ArgumentNullException(nameof(conversationId));
            this.Entries = entries ?? throw new global::System.ArgumentNullException(nameof(entries));
            this.Object = @object;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationHistory" /> class.
        /// </summary>
        public ConversationHistory()
        {
        }
    }
}