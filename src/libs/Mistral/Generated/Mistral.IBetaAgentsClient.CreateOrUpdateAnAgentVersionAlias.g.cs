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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mistral.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Mistral.AgentAliasResponse> CreateOrUpdateAnAgentVersionAliasAsync(
            string agentId,
            string alias,
            int version,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}