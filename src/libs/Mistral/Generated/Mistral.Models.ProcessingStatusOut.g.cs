
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
        [global::System.Text.Json.Serialization.JsonPropertyName("process_status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Mistral.JsonConverters.ProcessStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Mistral.ProcessStatus ProcessStatus { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("processing_status")]
        public string ProcessingStatus { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProcessingStatusOut" /> class.
        /// </summary>
        /// <param name="documentId"></param>
        /// <param name="processStatus"></param>
        /// <param name="processingStatus">
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ProcessingStatusOut(
            global::System.Guid documentId,
            global::Mistral.ProcessStatus processStatus,
            string processingStatus = default!)
        {
            this.DocumentId = documentId;
            this.ProcessStatus = processStatus;
            this.ProcessingStatus = processingStatus;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProcessingStatusOut" /> class.
        /// </summary>
        public ProcessingStatusOut()
        {
        }
    }
}