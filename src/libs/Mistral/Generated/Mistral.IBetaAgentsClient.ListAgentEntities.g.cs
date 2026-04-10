#nullable enable

namespace Mistral
{
    public partial interface IBetaAgentsClient
    {
        /// <summary>
        /// List agent entities.<br/>
        /// Retrieve a list of agent entities sorted by creation time.
        /// </summary>
        /// <param name="page">
        /// Page number (0-indexed)<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="pageSize">
        /// Number of agents per page<br/>
        /// Default Value: 20
        /// </param>
        /// <param name="deploymentChat"></param>
        /// <param name="sources"></param>
        /// <param name="name">
        /// Filter by agent name
        /// </param>
        /// <param name="search">
        /// Search agents by name or ID
        /// </param>
        /// <param name="id"></param>
        /// <param name="metadata"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mistral.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Mistral.Agent>> ListAgentEntitiesAsync(
            int? page = default,
            int? pageSize = default,
            bool? deploymentChat = default,
            global::System.Collections.Generic.IList<global::Mistral.RequestSource>? sources = default,
            string? name = default,
            string? search = default,
            string? id = default,
            object? metadata = default,
            global::Mistral.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}