
#nullable enable

namespace Mistral
{
    /// <summary>
    /// Confidence scores for the page. Populated when `confidence_scores_granularity` is set in the request.
    /// </summary>
    public sealed partial class OCRPageObjectConfidenceScores
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}