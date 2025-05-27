#nullable enable

namespace Mistral
{
    public partial interface IMistralClient
    {
        /// <summary>
        /// Append new entries to an existing conversation.<br/>
        /// Run completion on the history of the conversation and the user entries. Return the new created entries.
        /// </summary>
        /// <param name="conversationId">
        /// ID of the conversation to which we append entries.
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mistral.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Mistral.ConversationResponse> AppendNewEntriesToAnExistingConversationAsync(
            string conversationId,
            global::Mistral.ConversationAppendRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Append new entries to an existing conversation.<br/>
        /// Run completion on the history of the conversation and the user entries. Return the new created entries.
        /// </summary>
        /// <param name="conversationId">
        /// ID of the conversation to which we append entries.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Mistral.ConversationResponse> AppendNewEntriesToAnExistingConversationAsync(
            string conversationId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}