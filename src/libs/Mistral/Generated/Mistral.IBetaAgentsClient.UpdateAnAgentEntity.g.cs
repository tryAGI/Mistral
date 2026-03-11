#nullable enable

namespace Mistral
{
    public partial interface IBetaAgentsClient
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
        /// <param name="instructions">
        /// Instruction prompt the model will follow during the conversation.
        /// </param>
        /// <param name="tools">
        /// List of tools which are available to the model during the conversation.
        /// </param>
        /// <param name="completionArgs">
        /// Completion arguments that will be used to generate assistant responses. Can be overridden at each message request.
        /// </param>
        /// <param name="guardrails"></param>
        /// <param name="model"></param>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="handoffs"></param>
        /// <param name="deploymentChat"></param>
        /// <param name="metadata"></param>
        /// <param name="versionMessage"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Mistral.Agent> UpdateAnAgentEntityAsync(
            string agentId,
            string? instructions = default,
            global::System.Collections.Generic.IList<global::Mistral.ToolsItem3>? tools = default,
            global::Mistral.CompletionArgs? completionArgs = default,
            global::System.Collections.Generic.IList<global::Mistral.GuardrailConfig>? guardrails = default,
            string? model = default,
            string? name = default,
            string? description = default,
            global::System.Collections.Generic.IList<string>? handoffs = default,
            bool? deploymentChat = default,
            object? metadata = default,
            string? versionMessage = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}