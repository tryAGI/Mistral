#nullable enable

namespace Mistral
{
    public partial interface IBetaConnectorsClient
    {
        /// <summary>
        /// Delete user credentials for a connector.<br/>
        /// Delete credentials at the user level for a given connector.
        /// </summary>
        /// <param name="credentialsName"></param>
        /// <param name="connectorIdOrName"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mistral.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Mistral.MessageResponse> DeleteUserCredentialsForAConnectorAsync(
            string credentialsName,
            string connectorIdOrName,
            global::Mistral.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete user credentials for a connector.<br/>
        /// Delete credentials at the user level for a given connector.
        /// </summary>
        /// <param name="credentialsName"></param>
        /// <param name="connectorIdOrName"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mistral.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Mistral.AutoSDKHttpResponse<global::Mistral.MessageResponse>> DeleteUserCredentialsForAConnectorAsResponseAsync(
            string credentialsName,
            string connectorIdOrName,
            global::Mistral.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}