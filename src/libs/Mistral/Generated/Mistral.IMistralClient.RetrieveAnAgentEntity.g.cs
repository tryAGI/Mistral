#nullable enable

namespace Mistral
{
    public partial interface IMistralClient
    {
        /// <summary>
        /// Retrieve an agent entity.<br/>
        /// Given an agent retrieve an agent entity with its attributes.
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mistral.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Mistral.Agent> RetrieveAnAgentEntityAsync(
            string agentId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}