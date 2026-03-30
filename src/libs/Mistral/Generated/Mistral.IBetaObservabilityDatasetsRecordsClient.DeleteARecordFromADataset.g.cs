#nullable enable

namespace Mistral
{
    public partial interface IBetaObservabilityDatasetsRecordsClient
    {
        /// <summary>
        /// Delete a record from a dataset
        /// </summary>
        /// <param name="datasetRecordId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mistral.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteARecordFromADatasetAsync(
            global::System.Guid datasetRecordId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}