
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
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("extension")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Extension { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hash")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Hash { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_processed_at")]
        public global::System.DateTime? LastProcessedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("library_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid LibraryId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mime_type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string MimeType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("number_of_pages")]
        public int? NumberOfPages { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("processing_status")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProcessingStatus { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("size")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Size { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("summary")]
        public string? Summary { get; set; }

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
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("tokens_processing_total")]
        public int TokensProcessingTotal { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("uploaded_by_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid UploadedById { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("uploaded_by_type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UploadedByType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentOut" /> class.
        /// </summary>
        /// <param name="createdAt"></param>
        /// <param name="extension"></param>
        /// <param name="hash"></param>
        /// <param name="id"></param>
        /// <param name="lastProcessedAt"></param>
        /// <param name="libraryId"></param>
        /// <param name="mimeType"></param>
        /// <param name="name"></param>
        /// <param name="numberOfPages"></param>
        /// <param name="processingStatus"></param>
        /// <param name="size"></param>
        /// <param name="summary"></param>
        /// <param name="tokensProcessingMainContent"></param>
        /// <param name="tokensProcessingSummary"></param>
        /// <param name="tokensProcessingTotal">
        /// Included only in responses
        /// </param>
        /// <param name="uploadedById"></param>
        /// <param name="uploadedByType"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DocumentOut(
            global::System.DateTime createdAt,
            string extension,
            string hash,
            global::System.Guid id,
            global::System.Guid libraryId,
            string mimeType,
            string name,
            string processingStatus,
            int size,
            global::System.Guid uploadedById,
            string uploadedByType,
            global::System.DateTime? lastProcessedAt,
            int? numberOfPages,
            string? summary,
            int? tokensProcessingMainContent,
            int? tokensProcessingSummary,
            int tokensProcessingTotal = default!)
        {
            this.CreatedAt = createdAt;
            this.Extension = extension ?? throw new global::System.ArgumentNullException(nameof(extension));
            this.Hash = hash ?? throw new global::System.ArgumentNullException(nameof(hash));
            this.Id = id;
            this.LibraryId = libraryId;
            this.MimeType = mimeType ?? throw new global::System.ArgumentNullException(nameof(mimeType));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.ProcessingStatus = processingStatus ?? throw new global::System.ArgumentNullException(nameof(processingStatus));
            this.Size = size;
            this.UploadedById = uploadedById;
            this.UploadedByType = uploadedByType ?? throw new global::System.ArgumentNullException(nameof(uploadedByType));
            this.LastProcessedAt = lastProcessedAt;
            this.NumberOfPages = numberOfPages;
            this.Summary = summary;
            this.TokensProcessingMainContent = tokensProcessingMainContent;
            this.TokensProcessingSummary = tokensProcessingSummary;
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