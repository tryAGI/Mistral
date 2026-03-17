
#nullable enable

namespace Mistral
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PostCampaignInSchema
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("search_params")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Mistral.FilterPayload SearchParams { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("judge_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid JudgeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_nb_events")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int MaxNbEvents { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PostCampaignInSchema" /> class.
        /// </summary>
        /// <param name="searchParams"></param>
        /// <param name="judgeId"></param>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="maxNbEvents"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PostCampaignInSchema(
            global::Mistral.FilterPayload searchParams,
            global::System.Guid judgeId,
            string name,
            string description,
            int maxNbEvents)
        {
            this.SearchParams = searchParams ?? throw new global::System.ArgumentNullException(nameof(searchParams));
            this.JudgeId = judgeId;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.MaxNbEvents = maxNbEvents;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostCampaignInSchema" /> class.
        /// </summary>
        public PostCampaignInSchema()
        {
        }
    }
}