#nullable enable

namespace Mistral
{
    public partial interface IBetaObservabilityChatCompletionEventsClient
    {
        /// <summary>
        /// Get Chat Completion Events
        /// </summary>
        /// <param name="pageSize">
        /// Default Value: 50
        /// </param>
        /// <param name="cursor"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mistral.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Mistral.ChatCompletionEvents> GetChatCompletionEventsAsync(

            global::Mistral.GetChatCompletionEventsInSchema request,
            int? pageSize = default,
            string? cursor = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get Chat Completion Events
        /// </summary>
        /// <param name="pageSize">
        /// Default Value: 50
        /// </param>
        /// <param name="cursor"></param>
        /// <param name="searchParams"></param>
        /// <param name="extraFields"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Mistral.ChatCompletionEvents> GetChatCompletionEventsAsync(
            global::Mistral.FilterPayload searchParams,
            int? pageSize = default,
            string? cursor = default,
            global::System.Collections.Generic.IList<string>? extraFields = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}