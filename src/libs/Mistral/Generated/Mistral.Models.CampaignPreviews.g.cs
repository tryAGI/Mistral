
#nullable enable

namespace Mistral
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CampaignPreviews
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("campaigns")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Mistral.PaginatedResultCampaignPreview Campaigns { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CampaignPreviews" /> class.
        /// </summary>
        /// <param name="campaigns"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CampaignPreviews(
            global::Mistral.PaginatedResultCampaignPreview campaigns)
        {
            this.Campaigns = campaigns ?? throw new global::System.ArgumentNullException(nameof(campaigns));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CampaignPreviews" /> class.
        /// </summary>
        public CampaignPreviews()
        {
        }
    }
}