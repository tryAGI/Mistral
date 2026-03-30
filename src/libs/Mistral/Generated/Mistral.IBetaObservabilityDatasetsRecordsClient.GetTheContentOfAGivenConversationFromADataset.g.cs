#nullable enable

namespace Mistral
{
    public partial interface IBetaObservabilityDatasetsRecordsClient
    {
        /// <summary>
        /// Get the content of a given conversation from a dataset
        /// </summary>
        /// <param name="datasetRecordId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mistral.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Mistral.DatasetRecord> GetTheContentOfAGivenConversationFromADatasetAsync(
            global::System.Guid datasetRecordId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}