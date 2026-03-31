
#nullable enable

namespace Mistral
{
    /// <summary>
    /// A payload containing a list of JSON Patch operations.<br/>
    /// Used for streaming incremental updates to workflow state.
    /// </summary>
    public sealed partial class JSONPatchPayloadResponse
    {
        /// <summary>
        /// Discriminator indicating this is a JSON Patch payload.<br/>
        /// Default Value: json_patch
        /// </summary>
        /// <default>"json_patch"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "json_patch";

        /// <summary>
        /// The list of JSON Patch operations to apply in order.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Mistral.ValueItem> Value { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="JSONPatchPayloadResponse" /> class.
        /// </summary>
        /// <param name="value">
        /// The list of JSON Patch operations to apply in order.
        /// </param>
        /// <param name="type">
        /// Discriminator indicating this is a JSON Patch payload.<br/>
        /// Default Value: json_patch
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public JSONPatchPayloadResponse(
            global::System.Collections.Generic.IList<global::Mistral.ValueItem> value,
            string type = "json_patch")
        {
            this.Type = type;
            this.Value = value ?? throw new global::System.ArgumentNullException(nameof(value));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="JSONPatchPayloadResponse" /> class.
        /// </summary>
        public JSONPatchPayloadResponse()
        {
        }
    }
}