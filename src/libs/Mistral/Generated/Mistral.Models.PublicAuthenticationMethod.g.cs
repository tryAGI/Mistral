
#nullable enable

namespace Mistral
{
    /// <summary>
    /// Public view of an authentication method, without secrets.
    /// </summary>
    public sealed partial class PublicAuthenticationMethod
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("method_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Mistral.JsonConverters.OutboundAuthenticationTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Mistral.OutboundAuthenticationType MethodType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("headers")]
        public global::System.Collections.Generic.IList<global::Mistral.ConnectorAuthenticationHeader>? Headers { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PublicAuthenticationMethod" /> class.
        /// </summary>
        /// <param name="methodType"></param>
        /// <param name="headers"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PublicAuthenticationMethod(
            global::Mistral.OutboundAuthenticationType methodType,
            global::System.Collections.Generic.IList<global::Mistral.ConnectorAuthenticationHeader>? headers)
        {
            this.MethodType = methodType;
            this.Headers = headers;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PublicAuthenticationMethod" /> class.
        /// </summary>
        public PublicAuthenticationMethod()
        {
        }

    }
}