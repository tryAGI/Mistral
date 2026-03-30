#nullable enable

namespace Mistral
{
    public partial interface IBetaObservabilityDatasetsRecordsClient
    {
        /// <summary>
        /// Update conversation properties
        /// </summary>
        /// <param name="datasetRecordId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mistral.ApiException"></exception>
        global::System.Threading.Tasks.Task UpdateConversationPropertiesAsync(
            global::System.Guid datasetRecordId,

            global::Mistral.PutDatasetRecordPropertiesInSchema request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update conversation properties
        /// </summary>
        /// <param name="datasetRecordId"></param>
        /// <param name="properties"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task UpdateConversationPropertiesAsync(
            global::System.Guid datasetRecordId,
            object properties,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}