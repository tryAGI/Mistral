
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Mistral
{
    /// <summary>
    /// The contents of a resource, embedded into a prompt or tool call result.<br/>
    /// It is up to the client how best to render embedded resources for the benefit<br/>
    /// of the LLM and/or the user.
    /// </summary>
    public sealed partial class EmbeddedResource
    {
        /// <summary>
        /// 
        /// </summary>
        /// <default>"resource"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "resource";

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resource")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Mistral.JsonConverters.AnyOfJsonConverter<global::Mistral.TextResourceContents, global::Mistral.BlobResourceContents>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Mistral.AnyOf<global::Mistral.TextResourceContents, global::Mistral.BlobResourceContents> Resource { get; set; }

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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EmbeddedResource" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="resource"></param>
        /// <param name="annotations"></param>
        /// <param name="meta"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EmbeddedResource(
            global::Mistral.AnyOf<global::Mistral.TextResourceContents, global::Mistral.BlobResourceContents> resource,
            global::Mistral.Annotations? annotations,
            object? meta,
            string type = "resource")
        {
            this.Resource = resource;
            this.Type = type;
            this.Annotations = annotations;
            this.Meta = meta;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EmbeddedResource" /> class.
        /// </summary>
        public EmbeddedResource()
        {
        }
    }
}