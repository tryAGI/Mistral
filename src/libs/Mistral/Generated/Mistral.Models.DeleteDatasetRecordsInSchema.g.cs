
#nullable enable

namespace Mistral
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DeleteDatasetRecordsInSchema
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dataset_record_ids")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::System.Guid> DatasetRecordIds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteDatasetRecordsInSchema" /> class.
        /// </summary>
        /// <param name="datasetRecordIds"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeleteDatasetRecordsInSchema(
            global::System.Collections.Generic.IList<global::System.Guid> datasetRecordIds)
        {
            this.DatasetRecordIds = datasetRecordIds ?? throw new global::System.ArgumentNullException(nameof(datasetRecordIds));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteDatasetRecordsInSchema" /> class.
        /// </summary>
        public DeleteDatasetRecordsInSchema()
        {
        }
    }
}