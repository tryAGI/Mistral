#nullable enable

namespace Mistral
{
    public partial interface IMistralClient
    {
        /// <summary>
        /// Update an agent version.<br/>
        /// Switch the version of an agent.
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="version"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mistral.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Mistral.Agent> UpdateAnAgentVersionAsync(
            string agentId,
            int version,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}