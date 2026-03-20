#nullable enable

namespace Mistral
{
    public partial interface IFimClient
    {
        /// <summary>
        /// Fim Completion<br/>
        /// FIM completion.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mistral.ApiException"></exception>
        global::System.Collections.Generic.IAsyncEnumerable<global::Mistral.CompletionEvent> FimCompletionAsStreamAsync(

            global::Mistral.FIMCompletionRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Fim Completion<br/>
        /// FIM completion.
        /// </summary>
        /// <param name="model">
        /// ID of the model with FIM to use.<br/>
        /// Default Value: codestral-2404
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
        /// <param name="prompt">
        /// The text/code to complete.
        /// </param>
        /// <param name="suffix">
        /// Optional text/code that adds more context for the model. When given a `prompt` and a `suffix` the model will fill what is between them. When `suffix` is not provided, the model will simply execute completion starting with `prompt`.
        /// </param>
        /// <param name="minTokens">
        /// The minimum number of tokens to generate in the completion.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Collections.Generic.IAsyncEnumerable<global::Mistral.CompletionEvent> FimCompletionAsStreamAsync(
            string prompt,
            string model = "codestral-2404",
            double? temperature = default,
            double? topP = default,
            int? maxTokens = default,
            global::Mistral.AnyOf<string, global::System.Collections.Generic.IList<string>>? stop = default,
            int? randomSeed = default,
            object? metadata = default,
            string? suffix = default,
            int? minTokens = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}