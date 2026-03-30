#nullable enable

namespace Mistral
{
    public partial interface IBetaObservabilityChatCompletionEventsFieldsClient
    {
        /// <summary>
        /// Get Chat Completion Field Options Counts
        /// </summary>
        /// <param name="fieldName"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mistral.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Mistral.FieldOptionCounts> GetChatCompletionFieldOptionsCountsAsync(
            string fieldName,

            global::Mistral.FieldOptionCountsInSchema request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get Chat Completion Field Options Counts
        /// </summary>
        /// <param name="fieldName"></param>
        /// <param name="filterParams"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Mistral.FieldOptionCounts> GetChatCompletionFieldOptionsCountsAsync(
            string fieldName,
            global::Mistral.FilterPayload? filterParams = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}