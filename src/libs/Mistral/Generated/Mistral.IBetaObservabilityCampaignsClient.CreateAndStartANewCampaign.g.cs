#nullable enable

namespace Mistral
{
    public partial interface IBetaObservabilityCampaignsClient
    {
        /// <summary>
        /// Create and start a new campaign
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mistral.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Mistral.CampaignPreview> CreateAndStartANewCampaignAsync(

            global::Mistral.PostCampaignInSchema request,
            global::Mistral.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create and start a new campaign
        /// </summary>
        /// <param name="searchParams"></param>
        /// <param name="judgeId"></param>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="maxNbEvents"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Mistral.CampaignPreview> CreateAndStartANewCampaignAsync(
            global::Mistral.FilterPayload searchParams,
            global::System.Guid judgeId,
            string name,
            string description,
            int maxNbEvents,
            global::Mistral.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}