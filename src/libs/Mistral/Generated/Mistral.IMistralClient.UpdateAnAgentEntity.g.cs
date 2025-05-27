#nullable enable

namespace Mistral
{
    public partial interface IMistralClient
    {
        /// <summary>
        /// Update an agent entity.<br/>
        /// Update an agent attributes and create a new version.
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mistral.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Mistral.Agent> UpdateAnAgentEntityAsync(
            string agentId,
            global::Mistral.AgentUpdateRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Update an agent entity.<br/>
        /// Update an agent attributes and create a new version.
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="completionArgs">
        /// White-listed arguments from the completion API
        /// </param>
        /// <param name="description"></param>
        /// <param name="handoffs"></param>
        /// <param name="instructions">
        /// Instruction prompt the model will follow during the conversation.
        /// </param>
        /// <param name="model"></param>
        /// <param name="name"></param>
        /// <param name="tools">
        /// List of tools which are available to the model during the conversation.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Mistral.Agent> UpdateAnAgentEntityAsync(
            string agentId,
            global::Mistral.CompletionArgs? completionArgs = default,
            string? description = default,
            global::System.Collections.Generic.IList<string>? handoffs = default,
            string? instructions = default,
            string? model = default,
            string? name = default,
            global::System.Collections.Generic.IList<global::Mistral.ToolsItem3>? tools = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}