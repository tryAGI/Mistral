#nullable enable

namespace Mistral
{
    public partial interface IBetaAgentsClient
    {
        /// <summary>
        /// Create or update an agent version alias.<br/>
        /// Create a new alias or update an existing alias to point to a specific version. Aliases are unique per agent and can be reassigned to different versions.
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="alias"></param>
        /// <param name="version"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mistral.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Mistral.AgentAliasResponse> CreateOrUpdateAnAgentVersionAliasAsync(
            string agentId,
            string alias,
            int version,
            global::Mistral.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}