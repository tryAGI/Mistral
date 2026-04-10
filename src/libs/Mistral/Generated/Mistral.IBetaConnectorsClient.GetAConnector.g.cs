#nullable enable

namespace Mistral
{
    public partial interface IBetaConnectorsClient
    {
        /// <summary>
        /// Get a connector.<br/>
        /// Get a connector by its ID or name.
        /// </summary>
        /// <param name="fetchCustomerData">
        /// Fetch the customer data associated with the connector (e.g. customer secrets / config).<br/>
        /// Default Value: false
        /// </param>
        /// <param name="fetchConnectionSecrets">
        /// Fetch the general connection secrets associated with the connector.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="connectorIdOrName"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mistral.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Mistral.Connector> GetAConnectorAsync(
            string connectorIdOrName,
            bool? fetchCustomerData = default,
            bool? fetchConnectionSecrets = default,
            global::Mistral.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}