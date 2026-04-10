#nullable enable

namespace Mistral
{
    public partial interface IBetaObservabilityChatCompletionEventsClient
    {
        /// <summary>
        /// Alternative to /search that returns only the IDs and that can return many IDs at once
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mistral.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Mistral.ChatCompletionEventIds> AlternativeToSearchThatReturnsOnlyTheIDsAndThatCanReturnManyIDsAtOnceAsync(

            global::Mistral.GetChatCompletionEventIdsInSchema request,
            global::Mistral.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Alternative to /search that returns only the IDs and that can return many IDs at once
        /// </summary>
        /// <param name="searchParams"></param>
        /// <param name="extraFields"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Mistral.ChatCompletionEventIds> AlternativeToSearchThatReturnsOnlyTheIDsAndThatCanReturnManyIDsAtOnceAsync(
            global::Mistral.FilterPayload searchParams,
            global::System.Collections.Generic.IList<string>? extraFields = default,
            global::Mistral.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}