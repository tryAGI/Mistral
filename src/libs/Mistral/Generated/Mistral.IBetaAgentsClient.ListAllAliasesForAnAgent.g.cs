#nullable enable

namespace Mistral
{
    public partial interface IBetaAgentsClient
    {
        /// <summary>
        /// List all aliases for an agent.<br/>
        /// Retrieve all version aliases for a specific agent.
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mistral.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Mistral.AgentAliasResponse>> ListAllAliasesForAnAgentAsync(
            string agentId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}