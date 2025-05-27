#nullable enable

namespace Mistral
{
    public partial interface IMistralClient
    {
        /// <summary>
        /// List all created conversations.<br/>
        /// Retrieve a list of conversation entities sorted by creation time.
        /// </summary>
        /// <param name="page">
        /// Default Value: 0
        /// </param>
        /// <param name="pageSize">
        /// Default Value: 100
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mistral.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Mistral.AnyOf<global::Mistral.ModelConversation, global::Mistral.AgentConversation>>> ListAllCreatedConversationsAsync(
            int? page = default,
            int? pageSize = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}