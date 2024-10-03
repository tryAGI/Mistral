#nullable enable

namespace Mistral
{
    public partial interface IAgentsClient
    {
        /// <summary>
        /// Agents Completion
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Mistral.ChatCompletionResponse> AgentsCompletionAsync(
            global::Mistral.AgentsCompletionRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Agents Completion
        /// </summary>
        /// <param name="agentId">
        /// The ID of the agent to use for this completion.
        /// </param>
        /// <param name="maxTokens">
        /// The maximum number of tokens to generate in the completion. The token count of your prompt plus `max_tokens` cannot exceed the model's context length.
        /// </param>
        /// <param name="messages">
        /// The prompt(s) to generate completions for, encoded as a list of dict with role and content.<br/>
        /// Example: []
        /// </param>
        /// <param name="minTokens">
        /// The minimum number of tokens to generate in the completion.
        /// </param>
        /// <param name="randomSeed">
        /// The seed to use for random sampling. If set, different calls will generate deterministic results.
        /// </param>
        /// <param name="responseFormat"></param>
        /// <param name="stop">
        /// Stop generation if this token is detected. Or if one of these tokens is detected when providing an array
        /// </param>
        /// <param name="stream">
        /// Whether to stream back partial progress. If set, tokens will be sent as data-only server-side events as they become available, with the stream terminated by a data: [DONE] message. Otherwise, the server will hold the request open until the timeout or until completion, with the response containing the full result as JSON.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="toolChoice">
        /// Default Value: auto
        /// </param>
        /// <param name="tools"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Mistral.ChatCompletionResponse> AgentsCompletionAsync(
            string agentId,
            global::System.Collections.Generic.IList<global::Mistral.OneOf<global::Mistral.UserMessage, global::Mistral.AssistantMessage, global::Mistral.ToolMessage>> messages,
            int? maxTokens = default,
            int? minTokens = default,
            int? randomSeed = default,
            global::Mistral.ResponseFormat? responseFormat = default,
            global::Mistral.AnyOf<string, global::System.Collections.Generic.IList<string>>? stop = default,
            bool? stream = false,
            global::Mistral.AnyOf<global::Mistral.ToolChoice3, global::Mistral.ToolChoiceEnum?>? toolChoice = default,
            global::System.Collections.Generic.IList<global::Mistral.Tool>? tools = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}