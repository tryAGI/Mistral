#nullable enable

namespace Mistral
{
    public partial interface IBetaConnectorsClient
    {
        /// <summary>
        /// List all connectors.<br/>
        /// List all your custom connectors with keyset pagination and filters.
        /// </summary>
        /// <param name="queryFilters">
        /// Default Value: {"fetch_user_data":false,"fetch_customer_data":false,"fetch_connection_secrets":false,"fetch_execution_data":false}
        /// </param>
        /// <param name="cursor"></param>
        /// <param name="pageSize">
        /// Default Value: 100
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mistral.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Mistral.PaginatedConnectors> ListAllConnectorsAsync(
            global::Mistral.ConnectorsQueryFilters? queryFilters = default,
            string? cursor = default,
            int? pageSize = default,
            global::Mistral.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}