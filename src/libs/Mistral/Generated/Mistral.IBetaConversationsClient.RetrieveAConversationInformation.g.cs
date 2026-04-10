#nullable enable

namespace Mistral
{
    public partial interface IBetaConversationsClient
    {
        /// <summary>
        /// Retrieve a conversation information.<br/>
        /// Given a conversation_id retrieve a conversation entity with its attributes.
        /// </summary>
        /// <param name="conversationId">
        /// ID of the conversation from which we are fetching metadata.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mistral.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Mistral.AnyOf<global::Mistral.ModelConversation, global::Mistral.AgentConversation>> RetrieveAConversationInformationAsync(
            string conversationId,
            global::Mistral.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}