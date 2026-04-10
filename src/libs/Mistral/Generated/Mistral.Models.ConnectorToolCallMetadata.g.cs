
#nullable enable

namespace Mistral
{
    /// <summary>
    /// Metadata wrapper for MCP tool call responses.<br/>
    /// Nests MCP-specific fields under `mcp_meta` to avoid collisions with other<br/>
    /// metadata keys (e.g. `tool_call_result`) in Harmattan's streaming deltas.
    /// </summary>
    public sealed partial class ConnectorToolCallMetadata
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mcp_meta")]
        public global::Mistral.ConnectorToolResultMetadata? McpMeta { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectorToolCallMetadata" /> class.
        /// </summary>
        /// <param name="mcpMeta"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ConnectorToolCallMetadata(
            global::Mistral.ConnectorToolResultMetadata? mcpMeta)
        {
            this.McpMeta = mcpMeta;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectorToolCallMetadata" /> class.
        /// </summary>
        public ConnectorToolCallMetadata()
        {
        }
    }
}