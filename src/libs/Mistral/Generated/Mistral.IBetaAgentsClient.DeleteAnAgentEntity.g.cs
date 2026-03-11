#nullable enable

namespace Mistral
{
    public partial interface IBetaAgentsClient
    {
        /// <summary>
        /// Delete an agent entity.
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mistral.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteAnAgentEntityAsync(
            string agentId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}