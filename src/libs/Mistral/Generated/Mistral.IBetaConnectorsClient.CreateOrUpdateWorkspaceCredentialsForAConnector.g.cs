#nullable enable

namespace Mistral
{
    public partial interface IBetaConnectorsClient
    {
        /// <summary>
        /// Create or update workspace credentials for a connector.<br/>
        /// Create or update credentials at the workspace level for a given connector.
        /// </summary>
        /// <param name="connectorIdOrName"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mistral.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Mistral.MessageResponse> CreateOrUpdateWorkspaceCredentialsForAConnectorAsync(
            string connectorIdOrName,

            global::Mistral.CredentialsCreateOrUpdate request,
            global::Mistral.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create or update workspace credentials for a connector.<br/>
        /// Create or update credentials at the workspace level for a given connector.
        /// </summary>
        /// <param name="connectorIdOrName"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mistral.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Mistral.AutoSDKHttpResponse<global::Mistral.MessageResponse>> CreateOrUpdateWorkspaceCredentialsForAConnectorAsResponseAsync(
            string connectorIdOrName,

            global::Mistral.CredentialsCreateOrUpdate request,
            global::Mistral.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create or update workspace credentials for a connector.<br/>
        /// Create or update credentials at the workspace level for a given connector.
        /// </summary>
        /// <param name="connectorIdOrName"></param>
        /// <param name="name">
        /// Name of the credentials. Use this name to access or modify your credentials.
        /// </param>
        /// <param name="isDefault">
        /// Controls whether this credential is the default for its auth method. On creation: if no credential exists yet for this auth method, the credential is automatically set as default when is_default is true or omitted; setting is_default to false is rejected because a default must exist. If other credentials already exist, setting is_default to true promotes this credential (demoting the previous default); false or omitted creates it as non-default. On update: true promotes this credential, false is rejected if it is currently the default (promote another credential first), omitted leaves the default status unchanged.
        /// </param>
        /// <param name="credentials">
        /// The credential data (headers, bearer_token).
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Mistral.MessageResponse> CreateOrUpdateWorkspaceCredentialsForAConnectorAsync(
            string connectorIdOrName,
            string name,
            bool? isDefault = default,
            global::Mistral.ConnectionCredentials? credentials = default,
            global::Mistral.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}