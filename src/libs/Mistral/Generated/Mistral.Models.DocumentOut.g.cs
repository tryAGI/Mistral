
#nullable enable

namespace Mistral
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DocumentOut
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("library_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid LibraryId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hash")]
        public string? Hash { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mime_type")]
        public string? MimeType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("extension")]
        public string? Extension { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("size")]
        public int? Size { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("summary")]
        public string? Summary { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_processed_at")]
        public global::System.DateTime? LastProcessedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("number_of_pages")]
        public int? NumberOfPages { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("process_status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Mistral.JsonConverters.ProcessStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Mistral.ProcessStatus ProcessStatus { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("uploaded_by_id")]
        public global::System.Guid? UploadedById { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("uploaded_by_type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UploadedByType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tokens_processing_main_content")]
        public int? TokensProcessingMainContent { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tokens_processing_summary")]
        public int? TokensProcessingSummary { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        public string? Url { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("attributes")]
        public object? Attributes { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("processing_status")]
        public string ProcessingStatus { get; set; } = default!;

        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("tokens_processing_total")]
        public int TokensProcessingTotal { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentOut" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="libraryId"></param>
        /// <param name="name"></param>
        /// <param name="createdAt"></param>
        /// <param name="processStatus"></param>
        /// <param name="uploadedByType"></param>
        /// <param name="hash"></param>
        /// <param name="mimeType"></param>
        /// <param name="extension"></param>
        /// <param name="size"></param>
        /// <param name="summary"></param>
        /// <param name="lastProcessedAt"></param>
        /// <param name="numberOfPages"></param>
        /// <param name="uploadedById"></param>
        /// <param name="tokensProcessingMainContent"></param>
        /// <param name="tokensProcessingSummary"></param>
        /// <param name="url"></param>
        /// <param name="attributes"></param>
        /// <param name="processingStatus">
        /// Included only in responses
        /// </param>
        /// <param name="tokensProcessingTotal">
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DocumentOut(
            global::System.Guid id,
            global::System.Guid libraryId,
            string name,
            global::System.DateTime createdAt,
            global::Mistral.ProcessStatus processStatus,
            string uploadedByType,
            string? hash,
            string? mimeType,
            string? extension,
            int? size,
            string? summary,
            global::System.DateTime? lastProcessedAt,
            int? numberOfPages,
            global::System.Guid? uploadedById,
            int? tokensProcessingMainContent,
            int? tokensProcessingSummary,
            string? url,
            object? attributes,
            string processingStatus = default!,
            int tokensProcessingTotal = default!)
        {
            this.Id = id;
            this.LibraryId = libraryId;
            this.Hash = hash;
            this.MimeType = mimeType;
            this.Extension = extension;
            this.Size = size;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Summary = summary;
            this.CreatedAt = createdAt;
            this.LastProcessedAt = lastProcessedAt;
            this.NumberOfPages = numberOfPages;
            this.ProcessStatus = processStatus;
            this.UploadedById = uploadedById;
            this.UploadedByType = uploadedByType ?? throw new global::System.ArgumentNullException(nameof(uploadedByType));
            this.TokensProcessingMainContent = tokensProcessingMainContent;
            this.TokensProcessingSummary = tokensProcessingSummary;
            this.Url = url;
            this.Attributes = attributes;
            this.ProcessingStatus = processingStatus;
            this.TokensProcessingTotal = tokensProcessingTotal;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentOut" /> class.
        /// </summary>
        public DocumentOut()
        {
        }
    }
}