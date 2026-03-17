
#nullable enable

namespace Mistral
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DatasetRecords
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("records")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Mistral.PaginatedResultDatasetRecord Records { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DatasetRecords" /> class.
        /// </summary>
        /// <param name="records"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DatasetRecords(
            global::Mistral.PaginatedResultDatasetRecord records)
        {
            this.Records = records ?? throw new global::System.ArgumentNullException(nameof(records));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DatasetRecords" /> class.
        /// </summary>
        public DatasetRecords()
        {
        }
    }
}