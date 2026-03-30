#nullable enable

namespace Mistral
{
    public partial interface IBetaObservabilityDatasetsClient
    {
        /// <summary>
        /// Populate the dataset with a campaign
        /// </summary>
        /// <param name="datasetId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mistral.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Mistral.DatasetImportTask> PopulateTheDatasetWithACampaignAsync(
            global::System.Guid datasetId,

            global::Mistral.PostDatasetImportFromCampaignInSchema request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Populate the dataset with a campaign
        /// </summary>
        /// <param name="datasetId"></param>
        /// <param name="campaignId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Mistral.DatasetImportTask> PopulateTheDatasetWithACampaignAsync(
            global::System.Guid datasetId,
            global::System.Guid campaignId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}