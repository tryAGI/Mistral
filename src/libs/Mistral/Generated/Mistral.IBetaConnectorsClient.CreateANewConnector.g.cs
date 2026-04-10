#nullable enable

namespace Mistral
{
    public partial interface IBetaConnectorsClient
    {
        /// <summary>
        /// Create a new connector.<br/>
        /// Create a new MCP connector. You can customize its visibility, url and auth type.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mistral.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Mistral.Connector> CreateANewConnectorAsync(

            global::Mistral.CreateConnectorRequest request,
            global::Mistral.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a new connector.<br/>
        /// Create a new MCP connector. You can customize its visibility, url and auth type.
        /// </summary>
        /// <param name="name">
        /// The name of the connector. Should be 64 char length maximum, alphanumeric, only underscores/dashes.
        /// </param>
        /// <param name="description">
        /// The description of the connector.
        /// </param>
        /// <param name="iconUrl">
        /// The optional url of the icon you want to associate to the connector.
        /// </param>
        /// <param name="visibility">
        /// Visibility of the connector. Use 'shared_workspace' for workspace scoped connectors, or 'private' for private connectors.<br/>
        /// Default Value: shared_org
        /// </param>
        /// <param name="server">
        /// The url of the MCP server.
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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Mistral.Connector> CreateANewConnectorAsync(
            string name,
            string description,
            string server,
            string? iconUrl = default,
            global::Mistral.ResourceVisibility? visibility = default,
            object? headers = default,
            global::Mistral.AuthData? authData = default,
            string? systemPrompt = default,
            global::Mistral.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}