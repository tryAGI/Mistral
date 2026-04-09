
#nullable enable

namespace Mistral
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OCRConfidenceScore
    {
        /// <summary>
        /// Confidence score for the word, between 0 and 1.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("confidence")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Confidence { get; set; }

        /// <summary>
        /// Start index of the word in the markdown string.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int StartIndex { get; set; }

        /// <summary>
        /// The word text.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Text { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OCRConfidenceScore" /> class.
        /// </summary>
        /// <param name="confidence">
        /// Confidence score for the word, between 0 and 1.
        /// </param>
        /// <param name="startIndex">
        /// Start index of the word in the markdown string.
        /// </param>
        /// <param name="text">
        /// The word text.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OCRConfidenceScore(
            double confidence,
            int startIndex,
            string text)
        {
            this.Confidence = confidence;
            this.StartIndex = startIndex;
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OCRConfidenceScore" /> class.
        /// </summary>
        public OCRConfidenceScore()
        {
        }
    }
}