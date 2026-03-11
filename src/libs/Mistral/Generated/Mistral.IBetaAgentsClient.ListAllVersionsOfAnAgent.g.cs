#nullable enable

namespace Mistral
{
    public partial interface IBetaAgentsClient
    {
        /// <summary>
        /// List all versions of an agent.<br/>
        /// Retrieve all versions for a specific agent with full agent context. Supports pagination.
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="page">
        /// Page number (0-indexed)<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="pageSize">
        /// Number of versions per page<br/>
        /// Default Value: 20
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mistral.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Mistral.Agent>> ListAllVersionsOfAnAgentAsync(
            string agentId,
            int? page = default,
            int? pageSize = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}