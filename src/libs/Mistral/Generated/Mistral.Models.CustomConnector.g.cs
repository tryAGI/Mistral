
#nullable enable

namespace Mistral
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CustomConnector
    {
        /// <summary>
        /// Default Value: connector
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Mistral.JsonConverters.CustomConnectorTypeJsonConverter))]
        public global::Mistral.CustomConnectorType? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("connector_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ConnectorId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("authorization")]
        public global::Mistral.AuthorizationVariant1? Authorization { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_configuration")]
        public global::Mistral.ToolConfiguration? ToolConfiguration { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomConnector" /> class.
        /// </summary>
        /// <param name="type">
        /// Default Value: connector
        /// </param>
        /// <param name="connectorId"></param>
        /// <param name="authorization"></param>
        /// <param name="toolConfiguration"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CustomConnector(
            string connectorId,
            global::Mistral.CustomConnectorType? type,
            global::Mistral.AuthorizationVariant1? authorization,
            global::Mistral.ToolConfiguration? toolConfiguration)
        {
            this.ConnectorId = connectorId ?? throw new global::System.ArgumentNullException(nameof(connectorId));
            this.Type = type;
            this.Authorization = authorization;
            this.ToolConfiguration = toolConfiguration;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomConnector" /> class.
        /// </summary>
        public CustomConnector()
        {
        }
    }
}