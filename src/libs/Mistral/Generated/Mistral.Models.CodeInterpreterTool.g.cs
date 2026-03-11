
#nullable enable

namespace Mistral
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CodeInterpreterTool
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_configuration")]
        public global::Mistral.ToolConfiguration? ToolConfiguration { get; set; }

        /// <summary>
        /// Default Value: code_interpreter
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Mistral.JsonConverters.CodeInterpreterToolTypeJsonConverter))]
        public global::Mistral.CodeInterpreterToolType? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CodeInterpreterTool" /> class.
        /// </summary>
        /// <param name="toolConfiguration"></param>
        /// <param name="type">
        /// Default Value: code_interpreter
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CodeInterpreterTool(
            global::Mistral.ToolConfiguration? toolConfiguration,
            global::Mistral.CodeInterpreterToolType? type)
        {
            this.ToolConfiguration = toolConfiguration;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CodeInterpreterTool" /> class.
        /// </summary>
        public CodeInterpreterTool()
        {
        }
    }
}