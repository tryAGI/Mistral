
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Mistral
{
    /// <summary>
    /// The response after appending new entries to the conversation.
    /// </summary>
    public sealed partial class ConversationResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("conversation_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ConversationId { get; set; }

        /// <summary>
        /// Default Value: conversation.response
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Mistral.JsonConverters.ConversationResponseObjectJsonConverter))]
        public global::Mistral.ConversationResponseObject? Object { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("outputs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Mistral.AnyOf<global::Mistral.MessageOutputEntry, global::Mistral.ToolExecutionEntry, global::Mistral.FunctionCallEntry, global::Mistral.AgentHandoffEntry>> Outputs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("usage")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Mistral.ConversationUsageInfo Usage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationResponse" /> class.
        /// </summary>
        /// <param name="conversationId"></param>
        /// <param name="object">
        /// Default Value: conversation.response
        /// </param>
        /// <param name="outputs"></param>
        /// <param name="usage"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ConversationResponse(
            string conversationId,
            global::System.Collections.Generic.IList<global::Mistral.AnyOf<global::Mistral.MessageOutputEntry, global::Mistral.ToolExecutionEntry, global::Mistral.FunctionCallEntry, global::Mistral.AgentHandoffEntry>> outputs,
            global::Mistral.ConversationUsageInfo usage,
            global::Mistral.ConversationResponseObject? @object)
        {
            this.ConversationId = conversationId ?? throw new global::System.ArgumentNullException(nameof(conversationId));
            this.Outputs = outputs ?? throw new global::System.ArgumentNullException(nameof(outputs));
            this.Usage = usage ?? throw new global::System.ArgumentNullException(nameof(usage));
            this.Object = @object;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationResponse" /> class.
        /// </summary>
        public ConversationResponse()
        {
        }
    }
}