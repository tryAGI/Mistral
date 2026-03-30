#nullable enable

namespace Mistral
{
    public partial interface IBetaObservabilityDatasetsClient
    {
        /// <summary>
        /// Get dataset by id
        /// </summary>
        /// <param name="datasetId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mistral.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Mistral.DatasetPreview> GetDatasetByIdAsync(
            global::System.Guid datasetId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}