
#nullable enable

namespace Mistral
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class NetworkEncodedInput
    {
        /// <summary>
        /// The encoded payload
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("b64payload")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string B64payload { get; set; }

        /// <summary>
        /// The encoding of the payload<br/>
        /// Default Value: []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("encoding_options")]
        public global::System.Collections.Generic.IList<global::Mistral.EncodedPayloadOptions>? EncodingOptions { get; set; }

        /// <summary>
        /// Whether the payload is empty<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("empty")]
        public bool? Empty { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="NetworkEncodedInput" /> class.
        /// </summary>
        /// <param name="b64payload">
        /// The encoded payload
        /// </param>
        /// <param name="encodingOptions">
        /// The encoding of the payload<br/>
        /// Default Value: []
        /// </param>
        /// <param name="empty">
        /// Whether the payload is empty<br/>
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public NetworkEncodedInput(
            string b64payload,
            global::System.Collections.Generic.IList<global::Mistral.EncodedPayloadOptions>? encodingOptions,
            bool? empty)
        {
            this.B64payload = b64payload ?? throw new global::System.ArgumentNullException(nameof(b64payload));
            this.EncodingOptions = encodingOptions;
            this.Empty = empty;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NetworkEncodedInput" /> class.
        /// </summary>
        public NetworkEncodedInput()
        {
        }
    }
}