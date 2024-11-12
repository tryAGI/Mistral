
#nullable enable

namespace Mistral
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ClassificationObject
    {
        /// <summary>
        /// Classifier result thresholded
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("categories")]
        public global::System.Collections.Generic.Dictionary<string, bool>? Categories { get; set; }

        /// <summary>
        /// Classifier result
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("category_scores")]
        public global::System.Collections.Generic.Dictionary<string, double>? CategoryScores { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ClassificationObject" /> class.
        /// </summary>
        /// <param name="categories">
        /// Classifier result thresholded
        /// </param>
        /// <param name="categoryScores">
        /// Classifier result
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public ClassificationObject(
            global::System.Collections.Generic.Dictionary<string, bool>? categories,
            global::System.Collections.Generic.Dictionary<string, double>? categoryScores)
        {
            this.Categories = categories;
            this.CategoryScores = categoryScores;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ClassificationObject" /> class.
        /// </summary>
        public ClassificationObject()
        {
        }
    }
}