#nullable enable

namespace Mistral
{
    public partial interface IBetaObservabilityDatasetsClient
    {
        /// <summary>
        /// Populate the dataset with samples from an uploaded file
        /// </summary>
        /// <param name="datasetId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mistral.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Mistral.DatasetImportTask> PopulateTheDatasetWithSamplesFromAnUploadedFileAsync(
            global::System.Guid datasetId,

            global::Mistral.PostDatasetImportFromFileInSchema request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Populate the dataset with samples from an uploaded file
        /// </summary>
        /// <param name="datasetId"></param>
        /// <param name="fileId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Mistral.DatasetImportTask> PopulateTheDatasetWithSamplesFromAnUploadedFileAsync(
            global::System.Guid datasetId,
            string fileId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}