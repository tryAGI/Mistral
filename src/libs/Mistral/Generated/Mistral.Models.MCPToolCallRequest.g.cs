
#nullable enable

namespace Mistral
{
    /// <summary>
    /// Request body for calling an MCP tool.
    /// </summary>
    public sealed partial class MCPToolCallRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("arguments")]
        public object? Arguments { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MCPToolCallRequest" /> class.
        /// </summary>
        /// <param name="arguments"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MCPToolCallRequest(
            object? arguments)
        {
            this.Arguments = arguments;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MCPToolCallRequest" /> class.
        /// </summary>
        public MCPToolCallRequest()
        {
        }
    }
}