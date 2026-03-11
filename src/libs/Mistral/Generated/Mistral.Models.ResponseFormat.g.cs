
#nullable enable

namespace Mistral
{
    /// <summary>
    /// Specify the format that the model must output. By default it will use `{ "type": "text" }`. Setting to `{ "type": "json_object" }` enables JSON mode, which guarantees the message the model generates is in JSON. When using JSON mode you MUST also instruct the model to produce JSON yourself with a system or a user message. Setting to `{ "type": "json_schema" }` enables JSON schema mode, which guarantees the message the model generates is in JSON and follows the schema you provide.
    /// </summary>
    public sealed partial class ResponseFormat
    {
        /// <summary>
        /// Default Value: text
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Mistral.JsonConverters.ResponseFormatsJsonConverter))]
        public global::Mistral.ResponseFormats? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("json_schema")]
        public global::Mistral.JsonSchema? JsonSchema { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseFormat" /> class.
        /// </summary>
        /// <param name="type">
        /// Default Value: text
        /// </param>
        /// <param name="jsonSchema"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResponseFormat(
            global::Mistral.ResponseFormats? type,
            global::Mistral.JsonSchema? jsonSchema)
        {
            this.Type = type;
            this.JsonSchema = jsonSchema;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseFormat" /> class.
        /// </summary>
        public ResponseFormat()
        {
        }
    }
}