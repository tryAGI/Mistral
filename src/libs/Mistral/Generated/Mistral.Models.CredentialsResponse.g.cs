
#nullable enable

namespace Mistral
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CredentialsResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("credentials")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Mistral.AuthenticationConfiguration> Credentials { get; set; }

        /// <summary>
        /// Default Value: []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("connector_preset_credentials_for_auth")]
        public global::System.Collections.Generic.IList<global::Mistral.OutboundAuthenticationType>? ConnectorPresetCredentialsForAuth { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CredentialsResponse" /> class.
        /// </summary>
        /// <param name="credentials"></param>
        /// <param name="connectorPresetCredentialsForAuth">
        /// Default Value: []
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CredentialsResponse(
            global::System.Collections.Generic.IList<global::Mistral.AuthenticationConfiguration> credentials,
            global::System.Collections.Generic.IList<global::Mistral.OutboundAuthenticationType>? connectorPresetCredentialsForAuth)
        {
            this.Credentials = credentials ?? throw new global::System.ArgumentNullException(nameof(credentials));
            this.ConnectorPresetCredentialsForAuth = connectorPresetCredentialsForAuth;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CredentialsResponse" /> class.
        /// </summary>
        public CredentialsResponse()
        {
        }

    }
}