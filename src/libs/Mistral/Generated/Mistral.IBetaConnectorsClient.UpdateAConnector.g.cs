#nullable enable

namespace Mistral
{
    public partial interface IBetaConnectorsClient
    {
        /// <summary>
        /// Update a connector.<br/>
        /// Update a connector by its ID.
        /// </summary>
        /// <param name="connectorId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mistral.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Mistral.Connector> UpdateAConnectorAsync(
            global::System.Guid connectorId,

            global::Mistral.UpdateConnectorRequest request,
            global::Mistral.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update a connector.<br/>
        /// Update a connector by its ID.
        /// </summary>
        /// <param name="connectorId"></param>
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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Mistral.Connector> UpdateAConnectorAsync(
            global::System.Guid connectorId,
            string? name = default,
            string? description = default,
            string? iconUrl = default,
            string? systemPrompt = default,
            object? connectionConfig = default,
            object? connectionSecrets = default,
            string? server = default,
            object? headers = default,
            global::Mistral.AuthData? authData = default,
            global::Mistral.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}