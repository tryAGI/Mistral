
#nullable enable

namespace Mistral
{
    /// <summary>
    /// Response from calling an MCP tool.<br/>
    /// We override mcp_types.CallToolResult because:<br/>
    /// - Models only support `content`, not `structuredContent` at top level<br/>
    /// - Downstream consumers (le-chat, etc.) need structuredContent/isError/_meta via metadata<br/>
    /// SYNC: Keep in sync with Harmattan (orchestrator) for harmonized tool result processing.
    /// </summary>
    public sealed partial class ConnectorToolCallResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Mistral.AnyOf<global::Mistral.TextContent, global::Mistral.ImageContent, global::Mistral.AudioContent, global::Mistral.ResourceLink, global::Mistral.EmbeddedResource>> Content { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public global::Mistral.ConnectorToolCallMetadata? Metadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectorToolCallResponse" /> class.
        /// </summary>
        /// <param name="content"></param>
        /// <param name="metadata"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ConnectorToolCallResponse(
            global::System.Collections.Generic.IList<global::Mistral.AnyOf<global::Mistral.TextContent, global::Mistral.ImageContent, global::Mistral.AudioContent, global::Mistral.ResourceLink, global::Mistral.EmbeddedResource>> content,
            global::Mistral.ConnectorToolCallMetadata? metadata)
        {
            this.Content = content ?? throw new global::System.ArgumentNullException(nameof(content));
            this.Metadata = metadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectorToolCallResponse" /> class.
        /// </summary>
        public ConnectorToolCallResponse()
        {
        }
    }
}