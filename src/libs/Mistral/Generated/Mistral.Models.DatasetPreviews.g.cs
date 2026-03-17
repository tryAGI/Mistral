
#nullable enable

namespace Mistral
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DatasetPreviews
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("datasets")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Mistral.PaginatedResultDatasetPreview Datasets { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DatasetPreviews" /> class.
        /// </summary>
        /// <param name="datasets"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DatasetPreviews(
            global::Mistral.PaginatedResultDatasetPreview datasets)
        {
            this.Datasets = datasets ?? throw new global::System.ArgumentNullException(nameof(datasets));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DatasetPreviews" /> class.
        /// </summary>
        public DatasetPreviews()
        {
        }
    }
}