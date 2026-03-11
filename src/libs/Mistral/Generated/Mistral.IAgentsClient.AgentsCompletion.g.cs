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
        /// <exception cref="global::Mistral.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Mistral.ChatCompletionResponse> AgentsCompletionAsync(

            global::Mistral.AgentsCompletionRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Agents Completion
        /// </summary>
        /// <param name="maxTokens">
        /// The maximum number of tokens to generate in the completion. The token count of your prompt plus `max_tokens` cannot exceed the model's context length.
        /// </param>
        /// <param name="stream">
        /// Whether to stream back partial progress. If set, tokens will be sent as data-only server-side events as they become available, with the stream terminated by a data: [DONE] message. Otherwise, the server will hold the request open until the timeout or until completion, with the response containing the full result as JSON.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="stop">
        /// Stop generation if this token is detected. Or if one of these tokens is detected when providing an array
        /// </param>
        /// <param name="randomSeed">
        /// The seed to use for random sampling. If set, different calls will generate deterministic results.
        /// </param>
        /// <param name="metadata"></param>
        /// <param name="messages">
        /// The prompt(s) to generate completions for, encoded as a list of dict with role and content.
        /// </param>
        /// <param name="responseFormat">
        /// Specify the format that the model must output. By default it will use `{ "type": "text" }`. Setting to `{ "type": "json_object" }` enables JSON mode, which guarantees the message the model generates is in JSON. When using JSON mode you MUST also instruct the model to produce JSON yourself with a system or a user message. Setting to `{ "type": "json_schema" }` enables JSON schema mode, which guarantees the message the model generates is in JSON and follows the schema you provide.
        /// </param>
        /// <param name="tools"></param>
        /// <param name="toolChoice">
        /// Default Value: auto
        /// </param>
        /// <param name="presencePenalty">
        /// The `presence_penalty` determines how much the model penalizes the repetition of words or phrases. A higher presence penalty encourages the model to use a wider variety of words and phrases, making the output more diverse and creative.<br/>
        /// Default Value: 0.0
        /// </param>
        /// <param name="frequencyPenalty">
        /// The `frequency_penalty` penalizes the repetition of words based on their frequency in the generated text. A higher frequency penalty discourages the model from repeating words that have already appeared frequently in the output, promoting diversity and reducing repetition.<br/>
        /// Default Value: 0.0
        /// </param>
        /// <param name="n">
        /// Number of completions to return for each request, input tokens are only billed once.
        /// </param>
        /// <param name="prediction">
        /// Enable users to specify expected results, optimizing response times by leveraging known or predictable content. This approach is especially effective for updating text documents or code files with minimal changes, reducing latency while maintaining high-quality results.<br/>
        /// Default Value: {"type":"content","content":""}
        /// </param>
        /// <param name="parallelToolCalls">
        /// Default Value: true
        /// </param>
        /// <param name="promptMode">
        /// Allows toggling between the reasoning mode and no system prompt. When set to `reasoning` the system prompt for reasoning models will be used.
        /// </param>
        /// <param name="agentId">
        /// The ID of the agent to use for this completion.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Mistral.ChatCompletionResponse> AgentsCompletionAsync(
            global::System.Collections.Generic.IList<global::Mistral.MessagesItem3> messages,
            string agentId,
            int? maxTokens = default,
            bool? stream = default,
            global::Mistral.AnyOf<string, global::System.Collections.Generic.IList<string>>? stop = default,
            int? randomSeed = default,
            object? metadata = default,
            global::Mistral.ResponseFormat? responseFormat = default,
            global::System.Collections.Generic.IList<global::Mistral.Tool3>? tools = default,
            global::Mistral.AnyOf<global::Mistral.ToolChoice2, global::Mistral.ToolChoiceEnum?>? toolChoice = default,
            double? presencePenalty = default,
            double? frequencyPenalty = default,
            int? n = default,
            global::Mistral.Prediction? prediction = default,
            bool? parallelToolCalls = default,
            global::Mistral.MistralPromptMode? promptMode = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}