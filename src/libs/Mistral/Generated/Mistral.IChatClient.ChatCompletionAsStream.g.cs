#nullable enable

namespace Mistral
{
    public partial interface IChatClient
    {
        /// <summary>
        /// Chat Completion
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mistral.ApiException"></exception>
        global::System.Collections.Generic.IAsyncEnumerable<global::Mistral.CompletionEvent> ChatCompletionAsStreamAsync(

            global::Mistral.ChatCompletionRequest request,
            global::Mistral.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Chat Completion
        /// </summary>
        /// <param name="model">
        /// ID of the model to use. You can use the [List Available Models](/api/#tag/models/operation/list_models_v1_models_get) API to see all of your available models, or see our [Model overview](/models) for model descriptions.
        /// </param>
        /// <param name="temperature">
        /// What sampling temperature to use, we recommend between 0.0 and 0.7. Higher values like 0.7 will make the output more random, while lower values like 0.2 will make it more focused and deterministic. We generally recommend altering this or `top_p` but not both. The default value varies depending on the model you are targeting. Call the `/models` endpoint to retrieve the appropriate value.
        /// </param>
        /// <param name="topP">
        /// Nucleus sampling, where the model considers the results of the tokens with `top_p` probability mass. So 0.1 means only the tokens comprising the top 10% probability mass are considered. We generally recommend altering this or `temperature` but not both.<br/>
        /// Default Value: 1.0
        /// </param>
        /// <param name="maxTokens">
        /// The maximum number of tokens to generate in the completion. The token count of your prompt plus `max_tokens` cannot exceed the model's context length.
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
        /// <param name="tools">
        /// A list of tools the model may call. Use this to provide a list of functions the model may generate JSON inputs for.
        /// </param>
        /// <param name="toolChoice">
        /// Controls which (if any) tool is called by the model. `none` means the model will not call any tool and instead generates a message. `auto` means the model can pick between generating a message or calling one or more tools. `any` or `required` means the model must call one or more tools. Specifying a particular tool via `{"type": "function", "function": {"name": "my_function"}}` forces the model to call that tool.<br/>
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
        /// Whether to enable parallel function calling during tool use, when enabled the model can call multiple tools in parallel.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="promptMode">
        /// Allows toggling between the reasoning mode and no system prompt. When set to `reasoning` the system prompt for reasoning models will be used. **Deprecated for reasoning models - use `reasoning_effort` parameter instead.**
        /// </param>
        /// <param name="reasoningEffort">
        /// Controls the reasoning effort level for reasoning models. "high" enables comprehensive reasoning traces, "none" disables reasoning effort.
        /// </param>
        /// <param name="guardrails">
        /// A list of guardrail configurations to apply to this request. Each guardrail specifies a moderation type, categories with thresholds to evaluate, and an action to take on violation.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="safePrompt">
        /// Whether to inject a safety prompt before all conversations.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Collections.Generic.IAsyncEnumerable<global::Mistral.CompletionEvent> ChatCompletionAsStreamAsync(
            string model,
            global::System.Collections.Generic.IList<global::Mistral.MessagesItem> messages,
            double? temperature = default,
            double? topP = default,
            int? maxTokens = default,
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
            global::Mistral.ChatCompletionRequestReasoningEffort? reasoningEffort = default,
            global::System.Collections.Generic.IList<global::Mistral.GuardrailConfig>? guardrails = default,
            bool? safePrompt = default,
            global::Mistral.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}