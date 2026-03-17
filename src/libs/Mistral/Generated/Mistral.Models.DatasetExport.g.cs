
#nullable enable

namespace Mistral
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DatasetExport
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string FileUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DatasetExport" /> class.
        /// </summary>
        /// <param name="fileUrl"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DatasetExport(
            string fileUrl)
        {
            this.FileUrl = fileUrl ?? throw new global::System.ArgumentNullException(nameof(fileUrl));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DatasetExport" /> class.
        /// </summary>
        public DatasetExport()
        {
        }
    }
}