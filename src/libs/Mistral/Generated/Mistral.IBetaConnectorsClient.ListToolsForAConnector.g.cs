#nullable enable

namespace Mistral
{
    public partial interface IBetaConnectorsClient
    {
        /// <summary>
        /// List tools for a connector.<br/>
        /// List all tools available for an MCP connector.
        /// </summary>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="pageSize">
        /// Default Value: 100
        /// </param>
        /// <param name="refresh">
        /// Default Value: false
        /// </param>
        /// <param name="pretty">
        /// Return a simplified payload with only name, description, annotations, and a compact inputSchema.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="connectorIdOrName"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mistral.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Mistral.AnyOf<global::System.Collections.Generic.IList<global::Mistral.ConnectorTool>, global::System.Collections.Generic.IList<global::Mistral.MCPTool>, global::System.Collections.Generic.IList<object>>> ListToolsForAConnectorAsync(
            string connectorIdOrName,
            int? page = default,
            int? pageSize = default,
            bool? refresh = default,
            bool? pretty = default,
            global::Mistral.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}