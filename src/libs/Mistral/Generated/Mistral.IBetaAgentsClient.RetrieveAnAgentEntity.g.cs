#nullable enable

namespace Mistral
{
    public partial interface IBetaAgentsClient
    {

        /// <summary>
        /// Retrieve an agent entity.<br/>
        /// Given an agent, retrieve an agent entity with its attributes. The agent_version parameter can be an integer version number or a string alias.
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="agentVersion"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mistral.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Mistral.Agent> RetrieveAnAgentEntityAsync(
            string agentId,
            global::Mistral.AnyOf<int?, string, object>? agentVersion = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}