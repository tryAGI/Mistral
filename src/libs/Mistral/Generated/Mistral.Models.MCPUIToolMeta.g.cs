
#nullable enable

namespace Mistral
{
    /// <summary>
    /// UI metadata for tools that reference UI resources.
    /// </summary>
    public sealed partial class MCPUIToolMeta
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resourceUri")]
        public string? ResourceUri { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("visibility")]
        public global::System.Collections.Generic.IList<global::Mistral.MCPUIToolMetaVisibilityVariant1Item>? Visibility { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MCPUIToolMeta" /> class.
        /// </summary>
        /// <param name="resourceUri"></param>
        /// <param name="visibility"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MCPUIToolMeta(
            string? resourceUri,
            global::System.Collections.Generic.IList<global::Mistral.MCPUIToolMetaVisibilityVariant1Item>? visibility)
        {
            this.ResourceUri = resourceUri;
            this.Visibility = visibility;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MCPUIToolMeta" /> class.
        /// </summary>
        public MCPUIToolMeta()
        {
        }
    }
}