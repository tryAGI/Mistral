#nullable enable

namespace Mistral
{
    public partial interface IBetaAgentsClient
    {

        /// <summary>
        /// Retrieve a specific version of an agent.<br/>
        /// Get a specific agent version by version number.
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="version"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mistral.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Mistral.Agent> RetrieveASpecificVersionOfAnAgentAsync(
            string agentId,
            string version,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}