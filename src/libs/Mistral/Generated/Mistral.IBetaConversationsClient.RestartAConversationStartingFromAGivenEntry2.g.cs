#nullable enable

namespace Mistral
{
    public partial interface IBetaConversationsClient
    {
        /// <summary>
        /// Restart a conversation starting from a given entry.<br/>
        /// Given a conversation_id and an id, recreate a conversation from this point and run completion. A new conversation is returned with the new entries returned.
        /// </summary>
        /// <param name="conversationId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mistral.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Mistral.ConversationEvents> RestartAConversationStartingFromAGivenEntry2Async(
            string conversationId,
            global::Mistral.ConversationRestartStreamRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Restart a conversation starting from a given entry.<br/>
        /// Given a conversation_id and an id, recreate a conversation from this point and run completion. A new conversation is returned with the new entries returned.
        /// </summary>
        /// <param name="conversationId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Mistral.ConversationEvents> RestartAConversationStartingFromAGivenEntry2Async(
            string conversationId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}