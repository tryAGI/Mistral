
#nullable enable

namespace Mistral
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ConnectionCredentials
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("oauth")]
        public global::Mistral.OAuth2Token? Oauth { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("headers")]
        public global::System.Collections.Generic.Dictionary<string, string>? Headers { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bearer_token")]
        public string? BearerToken { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectionCredentials" /> class.
        /// </summary>
        /// <param name="oauth"></param>
        /// <param name="headers"></param>
        /// <param name="bearerToken"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ConnectionCredentials(
            global::Mistral.OAuth2Token? oauth,
            global::System.Collections.Generic.Dictionary<string, string>? headers,
            string? bearerToken)
        {
            this.Oauth = oauth;
            this.Headers = headers;
            this.BearerToken = bearerToken;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectionCredentials" /> class.
        /// </summary>
        public ConnectionCredentials()
        {
        }

    }
}