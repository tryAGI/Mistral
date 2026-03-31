
#nullable enable

namespace Mistral
{
    /// <summary>
    /// A payload containing arbitrary JSON data.<br/>
    /// Used for complete state snapshots or final results.
    /// </summary>
    public sealed partial class JSONPayloadResponse
    {
        /// <summary>
        /// Discriminator indicating this is a raw JSON payload.<br/>
        /// Default Value: json
        /// </summary>
        /// <default>"json"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "json";

        /// <summary>
        /// The JSON-serializable payload value.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Value { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="JSONPayloadResponse" /> class.
        /// </summary>
        /// <param name="value">
        /// The JSON-serializable payload value.
        /// </param>
        /// <param name="type">
        /// Discriminator indicating this is a raw JSON payload.<br/>
        /// Default Value: json
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public JSONPayloadResponse(
            object value,
            string type = "json")
        {
            this.Type = type;
            this.Value = value ?? throw new global::System.ArgumentNullException(nameof(value));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="JSONPayloadResponse" /> class.
        /// </summary>
        public JSONPayloadResponse()
        {
        }
    }
}