
#nullable enable

namespace Mistral
{
    /// <summary>
    /// Confidence score for a token or word in OCR output.
    /// </summary>
    public sealed partial class OCRConfidenceScore
    {
        /// <summary>
        /// The word or text segment
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Text { get; set; }

        /// <summary>
        /// Confidence score (0-1)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("confidence")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Confidence { get; set; }

        /// <summary>
        /// Start index of the text in the page markdown string
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int StartIndex { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OCRConfidenceScore" /> class.
        /// </summary>
        /// <param name="text">
        /// The word or text segment
        /// </param>
        /// <param name="confidence">
        /// Confidence score (0-1)
        /// </param>
        /// <param name="startIndex">
        /// Start index of the text in the page markdown string
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OCRConfidenceScore(
            string text,
            double confidence,
            int startIndex)
        {
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.Confidence = confidence;
            this.StartIndex = startIndex;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OCRConfidenceScore" /> class.
        /// </summary>
        public OCRConfidenceScore()
        {
        }

    }
}