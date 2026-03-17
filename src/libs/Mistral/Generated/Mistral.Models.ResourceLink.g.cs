
#nullable enable

namespace Mistral
{
    /// <summary>
    /// A resource that the server is capable of reading, included in a prompt or tool call result.<br/>
    /// Note: resource links returned by tools are not guaranteed to appear in the results of `resources/list` requests.
    /// </summary>
    public sealed partial class ResourceLink
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
        [global::System.Text.Json.Serialization.JsonPropertyName("uri")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Uri { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mimeType")]
        public string? MimeType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("size")]
        public int? Size { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("icons")]
        public global::System.Collections.Generic.IList<global::Mistral.MCPServerIcon>? Icons { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("annotations")]
        public global::Mistral.Annotations? Annotations { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("_meta")]
        public object? Meta { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <default>"resource_link"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "resource_link";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResourceLink" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="title"></param>
        /// <param name="uri"></param>
        /// <param name="description"></param>
        /// <param name="mimeType"></param>
        /// <param name="size"></param>
        /// <param name="icons"></param>
        /// <param name="annotations"></param>
        /// <param name="meta"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResourceLink(
            string name,
            string uri,
            string? title,
            string? description,
            string? mimeType,
            int? size,
            global::System.Collections.Generic.IList<global::Mistral.MCPServerIcon>? icons,
            global::Mistral.Annotations? annotations,
            object? meta,
            string type = "resource_link")
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Uri = uri ?? throw new global::System.ArgumentNullException(nameof(uri));
            this.Title = title;
            this.Description = description;
            this.MimeType = mimeType;
            this.Size = size;
            this.Icons = icons;
            this.Annotations = annotations;
            this.Meta = meta;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResourceLink" /> class.
        /// </summary>
        public ResourceLink()
        {
        }
    }
}