#nullable enable

namespace Mistral
{
    public partial interface IBetaConnectorsClient
    {
        /// <summary>
        /// List user credentials for a connector.<br/>
        /// List all credentials configured at the user level for a given connector.
        /// </summary>
        /// <param name="authType"></param>
        /// <param name="fetchDefault">
        /// Default Value: false
        /// </param>
        /// <param name="connectorIdOrName"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mistral.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Mistral.CredentialsResponse> ListUserCredentialsForAConnectorAsync(
            string connectorIdOrName,
            global::Mistral.OutboundAuthenticationType? authType = default,
            bool? fetchDefault = default,
            global::Mistral.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List user credentials for a connector.<br/>
        /// List all credentials configured at the user level for a given connector.
        /// </summary>
        /// <param name="authType"></param>
        /// <param name="fetchDefault">
        /// Default Value: false
        /// </param>
        /// <param name="connectorIdOrName"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mistral.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Mistral.AutoSDKHttpResponse<global::Mistral.CredentialsResponse>> ListUserCredentialsForAConnectorAsResponseAsync(
            string connectorIdOrName,
            global::Mistral.OutboundAuthenticationType? authType = default,
            bool? fetchDefault = default,
            global::Mistral.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}