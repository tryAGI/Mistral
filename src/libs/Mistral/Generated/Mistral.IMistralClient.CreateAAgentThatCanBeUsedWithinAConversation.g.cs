#nullable enable

namespace Mistral
{
    public partial interface IMistralClient
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
        global::System.Threading.Tasks.Task<global::Mistral.Agent> CreateAAgentThatCanBeUsedWithinAConversationAsync(
            string model,
            string name,
            global::Mistral.CompletionArgs? completionArgs = default,
            string? description = default,
            global::System.Collections.Generic.IList<string>? handoffs = default,
            string? instructions = default,
            global::System.Collections.Generic.IList<global::Mistral.ToolsItem2>? tools = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}