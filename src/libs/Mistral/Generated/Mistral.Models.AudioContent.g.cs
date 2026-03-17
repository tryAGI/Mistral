
#nullable enable

namespace Mistral
{
    /// <summary>
    /// Audio content for a message.
    /// </summary>
    public sealed partial class AudioContent
    {
        /// <summary>
        /// 
        /// </summary>
        /// <default>"audio"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "audio";

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Data { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mimeType")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string MimeType { get; set; }

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
        /// Initializes a new instance of the <see cref="AudioContent" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="data"></param>
        /// <param name="mimeType"></param>
        /// <param name="annotations"></param>
        /// <param name="meta"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AudioContent(
            string data,
            string mimeType,
            global::Mistral.Annotations? annotations,
            object? meta,
            string type = "audio")
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.MimeType = mimeType ?? throw new global::System.ArgumentNullException(nameof(mimeType));
            this.Type = type;
            this.Annotations = annotations;
            this.Meta = meta;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AudioContent" /> class.
        /// </summary>
        public AudioContent()
        {
        }
    }
}