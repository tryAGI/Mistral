#nullable enable

namespace Mistral
{
    public partial interface IBetaConnectorsClient
    {
        /// <summary>
        /// Delete workspace credentials for a connector.<br/>
        /// Delete credentials at the workspace level for a given connector.
        /// </summary>
        /// <param name="credentialsName"></param>
        /// <param name="connectorIdOrName"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mistral.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Mistral.MessageResponse> DeleteWorkspaceCredentialsForAConnectorAsync(
            string credentialsName,
            string connectorIdOrName,
            global::Mistral.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete workspace credentials for a connector.<br/>
        /// Delete credentials at the workspace level for a given connector.
        /// </summary>
        /// <param name="credentialsName"></param>
        /// <param name="connectorIdOrName"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mistral.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Mistral.AutoSDKHttpResponse<global::Mistral.MessageResponse>> DeleteWorkspaceCredentialsForAConnectorAsResponseAsync(
            string credentialsName,
            string connectorIdOrName,
            global::Mistral.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}