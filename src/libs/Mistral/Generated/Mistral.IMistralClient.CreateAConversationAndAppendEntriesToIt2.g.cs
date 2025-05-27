#nullable enable

namespace Mistral
{
    public partial interface IMistralClient
    {
        /// <summary>
        /// Create a conversation and append entries to it.<br/>
        /// Create a new conversation, using a base model or an agent and append entries. Completion and tool executions are run and the response is appended to the conversation.Use the returned conversation_id to continue the conversation.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mistral.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Mistral.ConversationEvents> CreateAConversationAndAppendEntriesToIt2Async(
            global::Mistral.ConversationStreamRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create a conversation and append entries to it.<br/>
        /// Create a new conversation, using a base model or an agent and append entries. Completion and tool executions are run and the response is appended to the conversation.Use the returned conversation_id to continue the conversation.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Mistral.ConversationEvents> CreateAConversationAndAppendEntriesToIt2Async(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}