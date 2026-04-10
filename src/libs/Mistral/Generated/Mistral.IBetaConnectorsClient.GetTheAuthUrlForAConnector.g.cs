#nullable enable

namespace Mistral
{
    public partial interface IBetaConnectorsClient
    {
        /// <summary>
        /// Get the auth URL for a connector.<br/>
        /// Get the OAuth2 authorization URL for a connector to initiate user authentication.
        /// </summary>
        /// <param name="appReturnUrl"></param>
        /// <param name="connectorIdOrName"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mistral.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Mistral.AuthUrlResponse> GetTheAuthUrlForAConnectorAsync(
            string connectorIdOrName,
            string? appReturnUrl = default,
            global::Mistral.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}