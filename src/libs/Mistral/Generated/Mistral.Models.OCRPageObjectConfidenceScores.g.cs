
#nullable enable

namespace Mistral
{
    /// <summary>
    /// Confidence scores for the OCR page (populated when confidence_scores_granularity is set)
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