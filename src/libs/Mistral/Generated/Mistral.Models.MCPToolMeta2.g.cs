
#nullable enable

namespace Mistral
{
    /// <summary>
    /// Typed _meta for MCP tools.<br/>
    /// Only the 'ui' field is typed. Other fields are allowed via extra="allow".
    /// </summary>
    public sealed partial class MCPToolMeta2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ui")]
        public global::Mistral.MCPUIToolMeta? Ui { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ai.mistral/turbine")]
        public global::Mistral.TurbineToolMeta? AiMistralTurbine { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MCPToolMeta2" /> class.
        /// </summary>
        /// <param name="ui"></param>
        /// <param name="aiMistralTurbine"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MCPToolMeta2(
            global::Mistral.MCPUIToolMeta? ui,
            global::Mistral.TurbineToolMeta? aiMistralTurbine)
        {
            this.Ui = ui;
            this.AiMistralTurbine = aiMistralTurbine;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MCPToolMeta2" /> class.
        /// </summary>
        public MCPToolMeta2()
        {
        }
    }
}