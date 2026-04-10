
#nullable enable

namespace Mistral
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateConnectorRequest
    {
        /// <summary>
        /// The name of the connector.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// The description of the connector.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// The optional url of the icon you want to associate to the connector.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("icon_url")]
        public string? IconUrl { get; set; }

        /// <summary>
        /// Optional system prompt for the connector.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("system_prompt")]
        public string? SystemPrompt { get; set; }

        /// <summary>
        /// Optional new connection config.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("connection_config")]
        public object? ConnectionConfig { get; set; }

        /// <summary>
        /// Optional new connection secrets
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("connection_secrets")]
        public object? ConnectionSecrets { get; set; }

        /// <summary>
        /// New server url for your mcp connector.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("server")]
        public string? Server { get; set; }

        /// <summary>
        /// New headers for your mcp connector.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("headers")]
        public object? Headers { get; set; }

        /// <summary>
        /// New authentication data for your mcp connector.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("auth_data")]
        public global::Mistral.AuthData? AuthData { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateConnectorRequest" /> class.
        /// </summary>
        /// <param name="name">
        /// The name of the connector.
        /// </param>
        /// <param name="description">
        /// The description of the connector.
        /// </param>
        /// <param name="iconUrl">
        /// The optional url of the icon you want to associate to the connector.
        /// </param>
        /// <param name="systemPrompt">
        /// Optional system prompt for the connector.
        /// </param>
        /// <param name="connectionConfig">
        /// Optional new connection config.
        /// </param>
        /// <param name="connectionSecrets">
        /// Optional new connection secrets
        /// </param>
        /// <param name="server">
        /// New server url for your mcp connector.
        /// </param>
        /// <param name="headers">
        /// New headers for your mcp connector.
        /// </param>
        /// <param name="authData">
        /// New authentication data for your mcp connector.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateConnectorRequest(
            string? name,
            string? description,
            string? iconUrl,
            string? systemPrompt,
            object? connectionConfig,
            object? connectionSecrets,
            string? server,
            object? headers,
            global::Mistral.AuthData? authData)
        {
            this.Name = name;
            this.Description = description;
            this.IconUrl = iconUrl;
            this.SystemPrompt = systemPrompt;
            this.ConnectionConfig = connectionConfig;
            this.ConnectionSecrets = connectionSecrets;
            this.Server = server;
            this.Headers = headers;
            this.AuthData = authData;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateConnectorRequest" /> class.
        /// </summary>
        public UpdateConnectorRequest()
        {
        }
    }
}