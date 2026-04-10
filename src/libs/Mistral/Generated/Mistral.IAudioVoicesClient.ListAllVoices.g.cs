#nullable enable

namespace Mistral
{
    public partial interface IAudioVoicesClient
    {
        /// <summary>
        /// List all voices<br/>
        /// List all voices (excluding sample data)
        /// </summary>
        /// <param name="limit">
        /// Maximum number of voices to return<br/>
        /// Default Value: 10
        /// </param>
        /// <param name="offset">
        /// Offset for pagination<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mistral.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Mistral.VoiceListResponse> ListAllVoicesAsync(
            int? limit = default,
            int? offset = default,
            global::Mistral.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}