
#nullable enable

namespace Mistral
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OCRPageConfidenceScores
    {
        /// <summary>
        /// Average confidence score across all words on the page, between 0 and 1.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("average_page_confidence_score")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double AveragePageConfidenceScore { get; set; }

        /// <summary>
        /// Minimum confidence score across all words on the page, between 0 and 1.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("minimum_page_confidence_score")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double MinimumPageConfidenceScore { get; set; }

        /// <summary>
        /// Per-word confidence scores. Returned when `confidence_scores_granularity` is set to `"word"`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("word_confidence_scores")]
        public global::System.Collections.Generic.IList<global::Mistral.OCRConfidenceScore>? WordConfidenceScores { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OCRPageConfidenceScores" /> class.
        /// </summary>
        /// <param name="averagePageConfidenceScore">
        /// Average confidence score across all words on the page, between 0 and 1.
        /// </param>
        /// <param name="minimumPageConfidenceScore">
        /// Minimum confidence score across all words on the page, between 0 and 1.
        /// </param>
        /// <param name="wordConfidenceScores">
        /// Per-word confidence scores. Returned when `confidence_scores_granularity` is set to `"word"`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OCRPageConfidenceScores(
            double averagePageConfidenceScore,
            double minimumPageConfidenceScore,
            global::System.Collections.Generic.IList<global::Mistral.OCRConfidenceScore>? wordConfidenceScores)
        {
            this.AveragePageConfidenceScore = averagePageConfidenceScore;
            this.MinimumPageConfidenceScore = minimumPageConfidenceScore;
            this.WordConfidenceScores = wordConfidenceScores;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OCRPageConfidenceScores" /> class.
        /// </summary>
        public OCRPageConfidenceScores()
        {
        }
    }
}