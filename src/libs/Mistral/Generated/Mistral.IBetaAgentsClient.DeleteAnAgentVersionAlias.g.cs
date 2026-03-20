#nullable enable

namespace Mistral
{
    public partial interface IBetaAgentsClient
    {

        /// <summary>
        /// Delete an agent version alias.<br/>
        /// Delete an existing alias for an agent.
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="alias"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mistral.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteAnAgentVersionAliasAsync(
            string agentId,
            string alias,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}