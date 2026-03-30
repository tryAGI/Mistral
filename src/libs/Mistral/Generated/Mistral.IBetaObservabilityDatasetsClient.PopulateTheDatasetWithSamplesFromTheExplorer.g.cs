#nullable enable

namespace Mistral
{
    public partial interface IBetaObservabilityDatasetsClient
    {
        /// <summary>
        /// Populate the dataset with samples from the explorer
        /// </summary>
        /// <param name="datasetId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mistral.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Mistral.DatasetImportTask> PopulateTheDatasetWithSamplesFromTheExplorerAsync(
            global::System.Guid datasetId,

            global::Mistral.PostDatasetImportFromExplorerInSchema request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Populate the dataset with samples from the explorer
        /// </summary>
        /// <param name="datasetId"></param>
        /// <param name="completionEventIds"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Mistral.DatasetImportTask> PopulateTheDatasetWithSamplesFromTheExplorerAsync(
            global::System.Guid datasetId,
            global::System.Collections.Generic.IList<string> completionEventIds,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}