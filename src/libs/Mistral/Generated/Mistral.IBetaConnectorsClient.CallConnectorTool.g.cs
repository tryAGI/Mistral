#nullable enable

namespace Mistral
{
    public partial interface IBetaConnectorsClient
    {
        /// <summary>
        /// Call Connector Tool<br/>
        /// Call a tool on an MCP connector.
        /// </summary>
        /// <param name="toolName"></param>
        /// <param name="credentialsName"></param>
        /// <param name="connectorIdOrName"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mistral.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Mistral.ConnectorToolCallResponse> CallConnectorToolAsync(
            string toolName,
            string connectorIdOrName,

            global::Mistral.ConnectorCallToolRequest request,
            string? credentialsName = default,
            global::Mistral.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Call Connector Tool<br/>
        /// Call a tool on an MCP connector.
        /// </summary>
        /// <param name="toolName"></param>
        /// <param name="credentialsName"></param>
        /// <param name="connectorIdOrName"></param>
        /// <param name="arguments"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Mistral.ConnectorToolCallResponse> CallConnectorToolAsync(
            string toolName,
            string connectorIdOrName,
            string? credentialsName = default,
            object? arguments = default,
            global::Mistral.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}