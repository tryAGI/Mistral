
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Mistral
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EmbeddingRequest
    {
        /// <summary>
        /// The format to return the embeddings in.<br/>
        /// Default Value: float
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("encoding_format")]
        public string? EncodingFormat { get; set; } = "float";

        /// <summary>
        /// Text to embed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Mistral.JsonConverters.AnyOfJsonConverterFactory2))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Mistral.AnyOf<string, global::System.Collections.Generic.IList<string>> Input { get; set; }

        /// <summary>
        /// ID of the model to use.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}