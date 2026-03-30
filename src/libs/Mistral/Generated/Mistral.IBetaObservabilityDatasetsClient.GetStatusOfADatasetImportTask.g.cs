#nullable enable

namespace Mistral
{
    public partial interface IBetaObservabilityDatasetsClient
    {
        /// <summary>
        /// Get status of a dataset import task
        /// </summary>
        /// <param name="datasetId"></param>
        /// <param name="taskId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mistral.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Mistral.DatasetImportTask> GetStatusOfADatasetImportTaskAsync(
            global::System.Guid datasetId,
            global::System.Guid taskId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}