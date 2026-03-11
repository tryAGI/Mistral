
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Mistral
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ToolReferenceChunk
    {
        /// <summary>
        /// Default Value: tool_reference
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Mistral.JsonConverters.AnyOfJsonConverter<global::Mistral.BuiltInConnectors?, string>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public global::Mistral.AnyOf<global::Mistral.BuiltInConnectors?, string> Tool { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public string Title { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        public string? Url { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("favicon")]
        public string? Favicon { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolReferenceChunk" /> class.
        /// </summary>
        /// <param name="type">
        /// Default Value: tool_reference
        /// </param>
        /// <param name="tool"></param>
        /// <param name="title"></param>
        /// <param name="url"></param>
        /// <param name="favicon"></param>
        /// <param name="description"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ToolReferenceChunk(
            global::Mistral.AnyOf<global::Mistral.BuiltInConnectors?, string> tool,
            string title,
            string? type,
            string? url,
            string? favicon,
            string? description)
        {
            this.Tool = tool;
            this.Title = title ?? throw new global::System.ArgumentNullException(nameof(title));
            this.Type = type;
            this.Url = url;
            this.Favicon = favicon;
            this.Description = description;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolReferenceChunk" /> class.
        /// </summary>
        public ToolReferenceChunk()
        {
        }
    }
}