
#nullable enable

namespace Mistral
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MCPTool
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inputSchema")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object InputSchema { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("outputSchema")]
        public object? OutputSchema { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("icons")]
        public global::System.Collections.Generic.IList<global::Mistral.MCPServerIcon>? Icons { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("annotations")]
        public global::Mistral.ToolAnnotations? Annotations { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("_meta")]
        public global::Mistral.MCPToolMeta2? Meta { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("execution")]
        public global::Mistral.ToolExecution? Execution { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MCPTool" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="inputSchema"></param>
        /// <param name="title"></param>
        /// <param name="description"></param>
        /// <param name="outputSchema"></param>
        /// <param name="icons"></param>
        /// <param name="annotations"></param>
        /// <param name="meta"></param>
        /// <param name="execution"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MCPTool(
            string name,
            object inputSchema,
            string? title,
            string? description,
            object? outputSchema,
            global::System.Collections.Generic.IList<global::Mistral.MCPServerIcon>? icons,
            global::Mistral.ToolAnnotations? annotations,
            global::Mistral.MCPToolMeta2? meta,
            global::Mistral.ToolExecution? execution)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Title = title;
            this.Description = description;
            this.InputSchema = inputSchema ?? throw new global::System.ArgumentNullException(nameof(inputSchema));
            this.OutputSchema = outputSchema;
            this.Icons = icons;
            this.Annotations = annotations;
            this.Meta = meta;
            this.Execution = execution;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MCPTool" /> class.
        /// </summary>
        public MCPTool()
        {
        }
    }
}