#nullable enable

namespace Mistral
{
    public partial interface IBetaObservabilityDatasetsClient
    {
        /// <summary>
        /// Populate the dataset with samples from another dataset
        /// </summary>
        /// <param name="datasetId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mistral.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Mistral.DatasetImportTask> PopulateTheDatasetWithSamplesFromAnotherDatasetAsync(
            global::System.Guid datasetId,

            global::Mistral.PostDatasetImportFromDatasetInSchema request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Populate the dataset with samples from another dataset
        /// </summary>
        /// <param name="datasetId"></param>
        /// <param name="datasetRecordIds"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Mistral.DatasetImportTask> PopulateTheDatasetWithSamplesFromAnotherDatasetAsync(
            global::System.Guid datasetId,
            global::System.Collections.Generic.IList<global::System.Guid> datasetRecordIds,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}