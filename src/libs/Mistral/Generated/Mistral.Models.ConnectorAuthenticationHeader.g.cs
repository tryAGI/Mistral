
#nullable enable

namespace Mistral
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ConnectorAuthenticationHeader
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_required")]
        public bool? IsRequired { get; set; }

        /// <summary>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_secret")]
        public bool? IsSecret { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectorAuthenticationHeader" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="isRequired">
        /// Default Value: true
        /// </param>
        /// <param name="isSecret">
        /// Default Value: true
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ConnectorAuthenticationHeader(
            string name,
            bool? isRequired,
            bool? isSecret)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.IsRequired = isRequired;
            this.IsSecret = isSecret;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectorAuthenticationHeader" /> class.
        /// </summary>
        public ConnectorAuthenticationHeader()
        {
        }

    }
}