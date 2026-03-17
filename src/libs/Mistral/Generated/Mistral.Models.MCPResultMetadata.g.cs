
#nullable enable

namespace Mistral
{
    /// <summary>
    /// MCP-specific result metadata (isError, structuredContent, _meta).
    /// </summary>
    public sealed partial class MCPResultMetadata
    {
        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("isError")]
        public bool? IsError { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("structuredContent")]
        public object? StructuredContent { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("_meta")]
        public object? Meta { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MCPResultMetadata" /> class.
        /// </summary>
        /// <param name="isError">
        /// Default Value: false
        /// </param>
        /// <param name="structuredContent"></param>
        /// <param name="meta"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MCPResultMetadata(
            bool? isError,
            object? structuredContent,
            object? meta)
        {
            this.IsError = isError;
            this.StructuredContent = structuredContent;
            this.Meta = meta;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MCPResultMetadata" /> class.
        /// </summary>
        public MCPResultMetadata()
        {
        }
    }
}