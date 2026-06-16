
#nullable enable

namespace Mistral
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AuthenticationConfiguration
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("authentication_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Mistral.JsonConverters.OutboundAuthenticationTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Mistral.OutboundAuthenticationType AuthenticationType { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_default")]
        public bool? IsDefault { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthenticationConfiguration" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="authenticationType"></param>
        /// <param name="isDefault">
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AuthenticationConfiguration(
            string name,
            global::Mistral.OutboundAuthenticationType authenticationType,
            bool? isDefault)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.AuthenticationType = authenticationType;
            this.IsDefault = isDefault;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthenticationConfiguration" /> class.
        /// </summary>
        public AuthenticationConfiguration()
        {
        }

    }
}