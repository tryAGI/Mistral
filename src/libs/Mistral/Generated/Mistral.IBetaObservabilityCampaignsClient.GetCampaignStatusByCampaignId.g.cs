#nullable enable

namespace Mistral
{
    public partial interface IBetaObservabilityCampaignsClient
    {
        /// <summary>
        /// Get campaign status by campaign id
        /// </summary>
        /// <param name="campaignId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mistral.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Mistral.CampaignStatus> GetCampaignStatusByCampaignIdAsync(
            global::System.Guid campaignId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}