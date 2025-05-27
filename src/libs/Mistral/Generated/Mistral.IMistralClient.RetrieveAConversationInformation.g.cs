#nullable enable

namespace Mistral
{
    public partial interface IMistralClient
    {
        /// <summary>
        /// Retrieve a conversation information.<br/>
        /// Given a conversation_id retrieve a conversation entity with its attributes.
        /// </summary>
        /// <param name="conversationId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mistral.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Mistral.AnyOf<global::Mistral.ModelConversation, global::Mistral.AgentConversation>> RetrieveAConversationInformationAsync(
            string conversationId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}