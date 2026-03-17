
#nullable enable

namespace Mistral
{
    /// <summary>
    /// Binary contents of a resource.
    /// </summary>
    public sealed partial class BlobResourceContents
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("uri")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Uri { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mimeType")]
        public string? MimeType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("_meta")]
        public object? Meta { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("blob")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Blob { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BlobResourceContents" /> class.
        /// </summary>
        /// <param name="uri"></param>
        /// <param name="mimeType"></param>
        /// <param name="meta"></param>
        /// <param name="blob"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BlobResourceContents(
            string uri,
            string blob,
            string? mimeType,
            object? meta)
        {
            this.Uri = uri ?? throw new global::System.ArgumentNullException(nameof(uri));
            this.Blob = blob ?? throw new global::System.ArgumentNullException(nameof(blob));
            this.MimeType = mimeType;
            this.Meta = meta;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BlobResourceContents" /> class.
        /// </summary>
        public BlobResourceContents()
        {
        }
    }
}