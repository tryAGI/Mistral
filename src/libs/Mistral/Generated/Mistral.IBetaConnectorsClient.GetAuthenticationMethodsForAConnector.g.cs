#nullable enable

namespace Mistral
{
    public partial interface IBetaConnectorsClient
    {
        /// <summary>
        /// Get authentication methods for a connector.<br/>
        /// Get the authentication schema for a connector. Returns the list of supported authentication methods and their required headers.
        /// </summary>
        /// <param name="connectorIdOrName"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mistral.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Mistral.PublicAuthenticationMethod>> GetAuthenticationMethodsForAConnectorAsync(
            string connectorIdOrName,
            global::Mistral.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get authentication methods for a connector.<br/>
        /// Get the authentication schema for a connector. Returns the list of supported authentication methods and their required headers.
        /// </summary>
        /// <param name="connectorIdOrName"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mistral.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Mistral.AutoSDKHttpResponse<global::System.Collections.Generic.IList<global::Mistral.PublicAuthenticationMethod>>> GetAuthenticationMethodsForAConnectorAsResponseAsync(
            string connectorIdOrName,
            global::Mistral.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}