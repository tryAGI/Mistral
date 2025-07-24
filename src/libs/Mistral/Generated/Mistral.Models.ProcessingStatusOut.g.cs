
#nullable enable

namespace Mistral
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ProcessingStatusOut
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("document_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid DocumentId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("processing_status")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProcessingStatus { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProcessingStatusOut" /> class.
        /// </summary>
        /// <param name="documentId"></param>
        /// <param name="processingStatus"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ProcessingStatusOut(
            global::System.Guid documentId,
            string processingStatus)
        {
            this.DocumentId = documentId;
            this.ProcessingStatus = processingStatus ?? throw new global::System.ArgumentNullException(nameof(processingStatus));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProcessingStatusOut" /> class.
        /// </summary>
        public ProcessingStatusOut()
        {
        }
    }
}