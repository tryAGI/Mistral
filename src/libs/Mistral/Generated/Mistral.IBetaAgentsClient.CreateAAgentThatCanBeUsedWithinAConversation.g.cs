#nullable enable

namespace Mistral
{
    public partial interface IBetaAgentsClient
    {
        /// <summary>
        /// Create a agent that can be used within a conversation.<br/>
        /// Create a new agent giving it instructions, tools, description. The agent is then available to be used as a regular assistant in a conversation or as part of an agent pool from which it can be used.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mistral.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Mistral.Agent> CreateAAgentThatCanBeUsedWithinAConversationAsync(

            global::Mistral.AgentCreationRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create a agent that can be used within a conversation.<br/>
        /// Create a new agent giving it instructions, tools, description. The agent is then available to be used as a regular assistant in a conversation or as part of an agent pool from which it can be used.
        /// </summary>
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
        /// <param name="metadata"></param>
        /// <param name="versionMessage"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Mistral.Agent> CreateAAgentThatCanBeUsedWithinAConversationAsync(
            string model,
            string name,
            string? instructions = default,
            global::System.Collections.Generic.IList<global::Mistral.ToolsItem2>? tools = default,
            global::Mistral.CompletionArgs? completionArgs = default,
            global::System.Collections.Generic.IList<global::Mistral.GuardrailConfig>? guardrails = default,
            string? description = default,
            global::System.Collections.Generic.IList<string>? handoffs = default,
            object? metadata = default,
            string? versionMessage = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}