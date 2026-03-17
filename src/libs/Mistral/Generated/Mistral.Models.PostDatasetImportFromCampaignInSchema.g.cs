
#nullable enable

namespace Mistral
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PostDatasetImportFromCampaignInSchema
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("campaign_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid CampaignId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PostDatasetImportFromCampaignInSchema" /> class.
        /// </summary>
        /// <param name="campaignId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PostDatasetImportFromCampaignInSchema(
            global::System.Guid campaignId)
        {
            this.CampaignId = campaignId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostDatasetImportFromCampaignInSchema" /> class.
        /// </summary>
        public PostDatasetImportFromCampaignInSchema()
        {
        }
    }
}