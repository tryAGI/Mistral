
#nullable enable

namespace Mistral
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DocumentLibraryTool
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_configuration")]
        public global::Mistral.ToolConfiguration? ToolConfiguration { get; set; }

        /// <summary>
        /// Default Value: document_library
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Mistral.JsonConverters.DocumentLibraryToolTypeJsonConverter))]
        public global::Mistral.DocumentLibraryToolType? Type { get; set; }

        /// <summary>
        /// Ids of the library in which to search.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("library_ids")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> LibraryIds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentLibraryTool" /> class.
        /// </summary>
        /// <param name="toolConfiguration"></param>
        /// <param name="type">
        /// Default Value: document_library
        /// </param>
        /// <param name="libraryIds">
        /// Ids of the library in which to search.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DocumentLibraryTool(
            global::System.Collections.Generic.IList<string> libraryIds,
            global::Mistral.ToolConfiguration? toolConfiguration,
            global::Mistral.DocumentLibraryToolType? type)
        {
            this.LibraryIds = libraryIds ?? throw new global::System.ArgumentNullException(nameof(libraryIds));
            this.ToolConfiguration = toolConfiguration;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentLibraryTool" /> class.
        /// </summary>
        public DocumentLibraryTool()
        {
        }
    }
}