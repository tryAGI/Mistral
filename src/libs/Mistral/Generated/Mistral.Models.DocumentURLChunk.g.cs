
#nullable enable

namespace Mistral
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DocumentURLChunk
    {
        /// <summary>
        /// Default Value: document_url
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("document_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DocumentUrl { get; set; }

        /// <summary>
        /// The filename of the document
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("document_name")]
        public string? DocumentName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentURLChunk" /> class.
        /// </summary>
        /// <param name="type">
        /// Default Value: document_url
        /// </param>
        /// <param name="documentUrl"></param>
        /// <param name="documentName">
        /// The filename of the document
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DocumentURLChunk(
            string documentUrl,
            string? type,
            string? documentName)
        {
            this.DocumentUrl = documentUrl ?? throw new global::System.ArgumentNullException(nameof(documentUrl));
            this.Type = type;
            this.DocumentName = documentName;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentURLChunk" /> class.
        /// </summary>
        public DocumentURLChunk()
        {
        }
    }
}