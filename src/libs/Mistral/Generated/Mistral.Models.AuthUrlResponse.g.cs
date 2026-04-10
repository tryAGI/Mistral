
#nullable enable

namespace Mistral
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AuthUrlResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("auth_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AuthUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ttl")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Ttl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthUrlResponse" /> class.
        /// </summary>
        /// <param name="authUrl"></param>
        /// <param name="ttl"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AuthUrlResponse(
            string authUrl,
            int ttl)
        {
            this.AuthUrl = authUrl ?? throw new global::System.ArgumentNullException(nameof(authUrl));
            this.Ttl = ttl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthUrlResponse" /> class.
        /// </summary>
        public AuthUrlResponse()
        {
        }
    }
}