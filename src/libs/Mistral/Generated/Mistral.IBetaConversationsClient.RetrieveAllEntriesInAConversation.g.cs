#nullable enable

namespace Mistral
{
    public partial interface IBetaConversationsClient
    {
        /// <summary>
        /// Retrieve all entries in a conversation.<br/>
        /// Given a conversation_id retrieve all the entries belonging to that conversation. The entries are sorted in the order they were appended, those can be messages, connectors or function_call.
        /// </summary>
        /// <param name="conversationId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mistral.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Mistral.ConversationHistory> RetrieveAllEntriesInAConversationAsync(
            string conversationId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}