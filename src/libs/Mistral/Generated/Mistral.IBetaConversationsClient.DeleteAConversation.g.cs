#nullable enable

namespace Mistral
{
    public partial interface IBetaConversationsClient
    {
        /// <summary>
        /// Delete a conversation.<br/>
        /// Delete a conversation given a conversation_id.
        /// </summary>
        /// <param name="conversationId">
        /// ID of the conversation from which we are fetching metadata.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mistral.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteAConversationAsync(
            string conversationId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}