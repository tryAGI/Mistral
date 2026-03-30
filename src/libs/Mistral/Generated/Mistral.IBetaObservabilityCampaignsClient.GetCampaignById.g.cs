#nullable enable

namespace Mistral
{
    public partial interface IBetaObservabilityCampaignsClient
    {
        /// <summary>
        /// Get campaign by id
        /// </summary>
        /// <param name="campaignId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mistral.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Mistral.CampaignPreview> GetCampaignByIdAsync(
            global::System.Guid campaignId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}