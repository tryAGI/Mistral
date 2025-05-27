
#nullable enable

namespace Mistral
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ToolReferenceChunk
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        public string? Source { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Title { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Mistral.JsonConverters.BuiltInConnectorsJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Mistral.BuiltInConnectors Tool { get; set; }

        /// <summary>
        /// Default Value: tool_reference
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Mistral.JsonConverters.ToolReferenceChunkTypeJsonConverter))]
        public global::Mistral.ToolReferenceChunkType? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        public string? Url { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolReferenceChunk" /> class.
        /// </summary>
        /// <param name="source"></param>
        /// <param name="title"></param>
        /// <param name="tool"></param>
        /// <param name="type">
        /// Default Value: tool_reference
        /// </param>
        /// <param name="url"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ToolReferenceChunk(
            string title,
            global::Mistral.BuiltInConnectors tool,
            string? source,
            global::Mistral.ToolReferenceChunkType? type,
            string? url)
        {
            this.Title = title ?? throw new global::System.ArgumentNullException(nameof(title));
            this.Tool = tool;
            this.Source = source;
            this.Type = type;
            this.Url = url;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolReferenceChunk" /> class.
        /// </summary>
        public ToolReferenceChunk()
        {
        }
    }
}