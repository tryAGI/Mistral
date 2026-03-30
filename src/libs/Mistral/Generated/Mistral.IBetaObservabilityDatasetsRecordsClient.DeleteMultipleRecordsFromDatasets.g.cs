#nullable enable

namespace Mistral
{
    public partial interface IBetaObservabilityDatasetsRecordsClient
    {
        /// <summary>
        /// Delete multiple records from datasets
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mistral.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteMultipleRecordsFromDatasetsAsync(

            global::Mistral.DeleteDatasetRecordsInSchema request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete multiple records from datasets
        /// </summary>
        /// <param name="datasetRecordIds"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task DeleteMultipleRecordsFromDatasetsAsync(
            global::System.Collections.Generic.IList<global::System.Guid> datasetRecordIds,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}