
#nullable enable

namespace Mistral
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FileChunk
    {
        /// <summary>
        /// Default Value: file
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public global::System.Guid FileId { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FileChunk" /> class.
        /// </summary>
        /// <param name="type">
        /// Default Value: file
        /// </param>
        /// <param name="fileId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FileChunk(
            global::System.Guid fileId,
            string? type)
        {
            this.FileId = fileId;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FileChunk" /> class.
        /// </summary>
        public FileChunk()
        {
        }
    }
}