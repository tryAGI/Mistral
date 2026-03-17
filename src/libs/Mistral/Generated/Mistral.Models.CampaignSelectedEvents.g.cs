
#nullable enable

namespace Mistral
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CampaignSelectedEvents
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completion_events")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Mistral.PaginatedResultChatCompletionEventPreview CompletionEvents { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CampaignSelectedEvents" /> class.
        /// </summary>
        /// <param name="completionEvents"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CampaignSelectedEvents(
            global::Mistral.PaginatedResultChatCompletionEventPreview completionEvents)
        {
            this.CompletionEvents = completionEvents ?? throw new global::System.ArgumentNullException(nameof(completionEvents));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CampaignSelectedEvents" /> class.
        /// </summary>
        public CampaignSelectedEvents()
        {
        }
    }
}