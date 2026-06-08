
#nullable enable

namespace Mistral
{
    /// <summary>
    /// Request to create or update non-OAuth2 credentials for a connector.
    /// </summary>
    public sealed partial class CredentialsCreateOrUpdate
    {
        /// <summary>
        /// Name of the credentials. Use this name to access or modify your credentials.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Controls whether this credential is the default for its auth method. On creation: if no credential exists yet for this auth method, the credential is automatically set as default when is_default is true or omitted; setting is_default to false is rejected because a default must exist. If other credentials already exist, setting is_default to true promotes this credential (demoting the previous default); false or omitted creates it as non-default. On update: true promotes this credential, false is rejected if it is currently the default (promote another credential first), omitted leaves the default status unchanged.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_default")]
        public bool? IsDefault { get; set; }

        /// <summary>
        /// The credential data (headers, bearer_token).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("credentials")]
        public global::Mistral.ConnectionCredentials? Credentials { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CredentialsCreateOrUpdate" /> class.
        /// </summary>
        /// <param name="name">
        /// Name of the credentials. Use this name to access or modify your credentials.
        /// </param>
        /// <param name="isDefault">
        /// Controls whether this credential is the default for its auth method. On creation: if no credential exists yet for this auth method, the credential is automatically set as default when is_default is true or omitted; setting is_default to false is rejected because a default must exist. If other credentials already exist, setting is_default to true promotes this credential (demoting the previous default); false or omitted creates it as non-default. On update: true promotes this credential, false is rejected if it is currently the default (promote another credential first), omitted leaves the default status unchanged.
        /// </param>
        /// <param name="credentials">
        /// The credential data (headers, bearer_token).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CredentialsCreateOrUpdate(
            string name,
            bool? isDefault,
            global::Mistral.ConnectionCredentials? credentials)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.IsDefault = isDefault;
            this.Credentials = credentials;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CredentialsCreateOrUpdate" /> class.
        /// </summary>
        public CredentialsCreateOrUpdate()
        {
        }

    }
}