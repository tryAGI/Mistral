
#nullable enable

namespace Mistral
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ConnectorMCPCreate
    {
        /// <summary>
        /// The name of the connector. Should be 64 char length maximum, alphanumeric, only underscores/dashes.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// The description of the connector.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Description { get; set; }

        /// <summary>
        /// The optional url of the icon you want to associate to the connector.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("icon_url")]
        public string? IconUrl { get; set; }

        /// <summary>
        /// Visibility of the connector. Use 'shared_workspace' for workspace scoped connectors, or 'private' for private connectors.<br/>
        /// Default Value: shared_org
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("visibility")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Mistral.JsonConverters.ResourceVisibilityJsonConverter))]
        public global::Mistral.ResourceVisibility? Visibility { get; set; }

        /// <summary>
        /// The url of the MCP server.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("server")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Server { get; set; }

        /// <summary>
        /// Optional organization-level headers to be sent with the request to the mcp server.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("headers")]
        public object? Headers { get; set; }

        /// <summary>
        /// Optional additional authentication data for the connector.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("auth_data")]
        public global::Mistral.AuthData? AuthData { get; set; }

        /// <summary>
        /// Optional system prompt for the connector.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("system_prompt")]
        public string? SystemPrompt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectorMCPCreate" /> class.
        /// </summary>
        /// <param name="name">
        /// The name of the connector. Should be 64 char length maximum, alphanumeric, only underscores/dashes.
        /// </param>
        /// <param name="description">
        /// The description of the connector.
        /// </param>
        /// <param name="server">
        /// The url of the MCP server.
        /// </param>
        /// <param name="iconUrl">
        /// The optional url of the icon you want to associate to the connector.
        /// </param>
        /// <param name="visibility">
        /// Visibility of the connector. Use 'shared_workspace' for workspace scoped connectors, or 'private' for private connectors.<br/>
        /// Default Value: shared_org
        /// </param>
        /// <param name="headers">
        /// Optional organization-level headers to be sent with the request to the mcp server.
        /// </param>
        /// <param name="authData">
        /// Optional additional authentication data for the connector.
        /// </param>
        /// <param name="systemPrompt">
        /// Optional system prompt for the connector.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ConnectorMCPCreate(
            string name,
            string description,
            string server,
            string? iconUrl,
            global::Mistral.ResourceVisibility? visibility,
            object? headers,
            global::Mistral.AuthData? authData,
            string? systemPrompt)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.IconUrl = iconUrl;
            this.Visibility = visibility;
            this.Server = server ?? throw new global::System.ArgumentNullException(nameof(server));
            this.Headers = headers;
            this.AuthData = authData;
            this.SystemPrompt = systemPrompt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectorMCPCreate" /> class.
        /// </summary>
        public ConnectorMCPCreate()
        {
        }
    }
}