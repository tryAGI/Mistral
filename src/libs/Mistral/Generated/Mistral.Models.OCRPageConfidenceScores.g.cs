
#nullable enable

namespace Mistral
{
    /// <summary>
    /// Confidence scores for an OCR page at various granularities.
    /// </summary>
    public sealed partial class OCRPageConfidenceScores
    {
        /// <summary>
        /// Word-level confidence scores (populated only for 'word' granularity)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("word_confidence_scores")]
        public global::System.Collections.Generic.IList<global::Mistral.OCRConfidenceScore>? WordConfidenceScores { get; set; }

        /// <summary>
        /// Average confidence score for the page
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("average_page_confidence_score")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double AveragePageConfidenceScore { get; set; }

        /// <summary>
        /// Minimum confidence score for the page
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("minimum_page_confidence_score")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double MinimumPageConfidenceScore { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OCRPageConfidenceScores" /> class.
        /// </summary>
        /// <param name="averagePageConfidenceScore">
        /// Average confidence score for the page
        /// </param>
        /// <param name="minimumPageConfidenceScore">
        /// Minimum confidence score for the page
        /// </param>
        /// <param name="wordConfidenceScores">
        /// Word-level confidence scores (populated only for 'word' granularity)
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OCRPageConfidenceScores(
            double averagePageConfidenceScore,
            double minimumPageConfidenceScore,
            global::System.Collections.Generic.IList<global::Mistral.OCRConfidenceScore>? wordConfidenceScores)
        {
            this.WordConfidenceScores = wordConfidenceScores;
            this.AveragePageConfidenceScore = averagePageConfidenceScore;
            this.MinimumPageConfidenceScore = minimumPageConfidenceScore;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OCRPageConfidenceScores" /> class.
        /// </summary>
        public OCRPageConfidenceScores()
        {
        }

    }
}