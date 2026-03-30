#nullable enable

namespace Mistral
{
    public partial interface IBetaObservabilityCampaignsClient
    {
        /// <summary>
        /// Get event ids that were selected by the given campaign
        /// </summary>
        /// <param name="campaignId"></param>
        /// <param name="pageSize">
        /// Default Value: 50
        /// </param>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mistral.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Mistral.CampaignSelectedEvents> GetEventIdsThatWereSelectedByTheGivenCampaignAsync(
            global::System.Guid campaignId,
            int? pageSize = default,
            int? page = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}