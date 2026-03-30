#nullable enable

namespace Mistral
{
    public partial interface IBetaObservabilityDatasetsClient
    {
        /// <summary>
        /// Add a conversation to the dataset
        /// </summary>
        /// <param name="datasetId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mistral.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Mistral.DatasetRecord> AddAConversationToTheDatasetAsync(
            global::System.Guid datasetId,

            global::Mistral.PostDatasetRecordInSchema request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Add a conversation to the dataset
        /// </summary>
        /// <param name="datasetId"></param>
        /// <param name="payload"></param>
        /// <param name="properties"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Mistral.DatasetRecord> AddAConversationToTheDatasetAsync(
            global::System.Guid datasetId,
            global::Mistral.ConversationPayload payload,
            object properties,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}