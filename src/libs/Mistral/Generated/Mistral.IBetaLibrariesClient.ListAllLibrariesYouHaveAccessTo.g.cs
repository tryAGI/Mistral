#nullable enable

namespace Mistral
{
    public partial interface IBetaLibrariesClient
    {
        /// <summary>
        /// List all libraries you have access to.<br/>
        /// List all libraries that you have created or have been shared with you.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mistral.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Mistral.ListLibraryOut> ListAllLibrariesYouHaveAccessToAsync(
            global::Mistral.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}