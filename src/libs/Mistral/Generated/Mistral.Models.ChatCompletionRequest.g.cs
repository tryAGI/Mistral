
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Mistral
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatCompletionRequest
    {
        /// <summary>
        /// ID of the model to use. You can use the [List Available Models](/api/#tag/models/operation/list_models_v1_models_get) API to see all of your available models, or see our [Model overview](/models) for model descriptions.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; }

        /// <summary>
        /// What sampling temperature to use, we recommend between 0.0 and 0.7. Higher values like 0.7 will make the output more random, while lower values like 0.2 will make it more focused and deterministic. We generally recommend altering this or `top_p` but not both. The default value varies depending on the model you are targeting. Call the `/models` endpoint to retrieve the appropriate value.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("temperature")]
        public double? Temperature { get; set; }

        /// <summary>
        /// Nucleus sampling, where the model considers the results of the tokens with `top_p` probability mass. So 0.1 means only the tokens comprising the top 10% probability mass are considered. We generally recommend altering this or `temperature` but not both.<br/>
        /// Default Value: 1.0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("top_p")]
        public double? TopP { get; set; }

        /// <summary>
        /// The maximum number of tokens to generate in the completion. The token count of your prompt plus `max_tokens` cannot exceed the model's context length.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_tokens")]
        public int? MaxTokens { get; set; }

        /// <summary>
        /// Whether to stream back partial progress. If set, tokens will be sent as data-only server-side events as they become available, with the stream terminated by a data: [DONE] message. Otherwise, the server will hold the request open until the timeout or until completion, with the response containing the full result as JSON.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stream")]
        public bool? Stream { get; set; }

        /// <summary>
        /// Stop generation if this token is detected. Or if one of these tokens is detected when providing an array
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stop")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Mistral.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>))]
        public global::Mistral.AnyOf<string, global::System.Collections.Generic.IList<string>>? Stop { get; set; }

        /// <summary>
        /// The seed to use for random sampling. If set, different calls will generate deterministic results.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("random_seed")]
        public int? RandomSeed { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// The prompt(s) to generate completions for, encoded as a list of dict with role and content.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("messages")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Mistral.MessagesItem> Messages { get; set; }

        /// <summary>
        /// Specify the format that the model must output. By default it will use `{ "type": "text" }`. Setting to `{ "type": "json_object" }` enables JSON mode, which guarantees the message the model generates is in JSON. When using JSON mode you MUST also instruct the model to produce JSON yourself with a system or a user message. Setting to `{ "type": "json_schema" }` enables JSON schema mode, which guarantees the message the model generates is in JSON and follows the schema you provide.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("response_format")]
        public global::Mistral.ResponseFormat? ResponseFormat { get; set; }

        /// <summary>
        /// A list of tools the model may call. Use this to provide a list of functions the model may generate JSON inputs for.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tools")]
        public global::System.Collections.Generic.IList<global::Mistral.Tool3>? Tools { get; set; }

        /// <summary>
        /// Controls which (if any) tool is called by the model. `none` means the model will not call any tool and instead generates a message. `auto` means the model can pick between generating a message or calling one or more tools. `any` or `required` means the model must call one or more tools. Specifying a particular tool via `{"type": "function", "function": {"name": "my_function"}}` forces the model to call that tool.<br/>
        /// Default Value: auto
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_choice")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Mistral.JsonConverters.AnyOfJsonConverter<global::Mistral.ToolChoice2, global::Mistral.ToolChoiceEnum?>))]
        public global::Mistral.AnyOf<global::Mistral.ToolChoice2, global::Mistral.ToolChoiceEnum?>? ToolChoice { get; set; }

        /// <summary>
        /// The `presence_penalty` determines how much the model penalizes the repetition of words or phrases. A higher presence penalty encourages the model to use a wider variety of words and phrases, making the output more diverse and creative.<br/>
        /// Default Value: 0.0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("presence_penalty")]
        public double? PresencePenalty { get; set; }

        /// <summary>
        /// The `frequency_penalty` penalizes the repetition of words based on their frequency in the generated text. A higher frequency penalty discourages the model from repeating words that have already appeared frequently in the output, promoting diversity and reducing repetition.<br/>
        /// Default Value: 0.0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("frequency_penalty")]
        public double? FrequencyPenalty { get; set; }

        /// <summary>
        /// Number of completions to return for each request, input tokens are only billed once.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("n")]
        public int? N { get; set; }

        /// <summary>
        /// Enable users to specify expected results, optimizing response times by leveraging known or predictable content. This approach is especially effective for updating text documents or code files with minimal changes, reducing latency while maintaining high-quality results.<br/>
        /// Default Value: {"type":"content","content":""}
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prediction")]
        public global::Mistral.Prediction? Prediction { get; set; }

        /// <summary>
        /// Whether to enable parallel function calling during tool use, when enabled the model can call multiple tools in parallel.<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parallel_tool_calls")]
        public bool? ParallelToolCalls { get; set; }

        /// <summary>
        /// Allows toggling between the reasoning mode and no system prompt. When set to `reasoning` the system prompt for reasoning models will be used.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_mode")]
        public global::Mistral.MistralPromptMode? PromptMode { get; set; }

        /// <summary>
        /// A list of guardrail configurations to apply to this request. Each guardrail specifies a moderation type, categories with thresholds to evaluate, and an action to take on violation.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("guardrails")]
        public global::System.Collections.Generic.IList<global::Mistral.GuardrailConfig>? Guardrails { get; set; }

        /// <summary>
        /// Whether to inject a safety prompt before all conversations.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("safe_prompt")]
        public bool? SafePrompt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionRequest" /> class.
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
        /// Allows toggling between the reasoning mode and no system prompt. When set to `reasoning` the system prompt for reasoning models will be used.
        /// </param>
        /// <param name="guardrails">
        /// A list of guardrail configurations to apply to this request. Each guardrail specifies a moderation type, categories with thresholds to evaluate, and an action to take on violation.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="safePrompt">
        /// Whether to inject a safety prompt before all conversations.<br/>
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatCompletionRequest(
            string model,
            global::System.Collections.Generic.IList<global::Mistral.MessagesItem> messages,
            double? temperature,
            double? topP,
            int? maxTokens,
            bool? stream,
            global::Mistral.AnyOf<string, global::System.Collections.Generic.IList<string>>? stop,
            int? randomSeed,
            object? metadata,
            global::Mistral.ResponseFormat? responseFormat,
            global::System.Collections.Generic.IList<global::Mistral.Tool3>? tools,
            global::Mistral.AnyOf<global::Mistral.ToolChoice2, global::Mistral.ToolChoiceEnum?>? toolChoice,
            double? presencePenalty,
            double? frequencyPenalty,
            int? n,
            global::Mistral.Prediction? prediction,
            bool? parallelToolCalls,
            global::Mistral.MistralPromptMode? promptMode,
            global::System.Collections.Generic.IList<global::Mistral.GuardrailConfig>? guardrails,
            bool? safePrompt)
        {
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.Messages = messages ?? throw new global::System.ArgumentNullException(nameof(messages));
            this.Temperature = temperature;
            this.TopP = topP;
            this.MaxTokens = maxTokens;
            this.Stream = stream;
            this.Stop = stop;
            this.RandomSeed = randomSeed;
            this.Metadata = metadata;
            this.ResponseFormat = responseFormat;
            this.Tools = tools;
            this.ToolChoice = toolChoice;
            this.PresencePenalty = presencePenalty;
            this.FrequencyPenalty = frequencyPenalty;
            this.N = n;
            this.Prediction = prediction;
            this.ParallelToolCalls = parallelToolCalls;
            this.PromptMode = promptMode;
            this.Guardrails = guardrails;
            this.SafePrompt = safePrompt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionRequest" /> class.
        /// </summary>
        public ChatCompletionRequest()
        {
        }
    }
}