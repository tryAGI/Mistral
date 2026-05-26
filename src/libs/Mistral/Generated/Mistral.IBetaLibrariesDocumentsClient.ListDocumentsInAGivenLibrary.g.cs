#nullable enable

namespace Mistral
{
    public partial interface IBetaLibrariesDocumentsClient
    {
        /// <summary>
        /// List documents in a given library.<br/>
        /// Given a library, lists the document that have been uploaded to that library.
        /// </summary>
        /// <param name="libraryId"></param>
        /// <param name="search"></param>
        /// <param name="pageSize">
        /// Default Value: 100
        /// </param>
        /// <param name="page">
        /// Default Value: 0
        /// </param>
        /// <param name="filtersAttributes"></param>
        /// <param name="sortBy">
        /// Default Value: created_at
        /// </param>
        /// <param name="sortOrder">
        /// Default Value: desc
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mistral.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Mistral.ListDocumentOut> ListDocumentsInAGivenLibraryAsync(
            global::System.Guid libraryId,
            string? search = default,
            int? pageSize = default,
            int? page = default,
            string? filtersAttributes = default,
            string? sortBy = default,
            string? sortOrder = default,
            global::Mistral.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List documents in a given library.<br/>
        /// Given a library, lists the document that have been uploaded to that library.
        /// </summary>
        /// <param name="libraryId"></param>
        /// <param name="search"></param>
        /// <param name="pageSize">
        /// Default Value: 100
        /// </param>
        /// <param name="page">
        /// Default Value: 0
        /// </param>
        /// <param name="filtersAttributes"></param>
        /// <param name="sortBy">
        /// Default Value: created_at
        /// </param>
        /// <param name="sortOrder">
        /// Default Value: desc
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mistral.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Mistral.AutoSDKHttpResponse<global::Mistral.ListDocumentOut>> ListDocumentsInAGivenLibraryAsResponseAsync(
            global::System.Guid libraryId,
            string? search = default,
            int? pageSize = default,
            int? page = default,
            string? filtersAttributes = default,
            string? sortBy = default,
            string? sortOrder = default,
            global::Mistral.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Wraps ListDocumentsInAGivenLibraryAsync as an IAsyncEnumerable<global::Mistral.DocumentOut> that auto-pages over the response.
        /// </summary>
        /// <param name="libraryId"></param>
        /// <param name="search"></param>
        /// <param name="pageSize">
        /// Default Value: 100
        /// </param>
        /// <param name="filtersAttributes"></param>
        /// <param name="sortBy">
        /// Default Value: created_at
        /// </param>
        /// <param name="sortOrder">
        /// Default Value: desc
        /// </param> 
        /// <param name="page">Initial page number to start enumerating from. Defaults to 1.</param>
        /// <param name="cancellationToken"></param>
        global::System.Collections.Generic.IAsyncEnumerable<global::Mistral.DocumentOut> ListDocumentsInAGivenLibraryAutoPagingAsync(
            global::System.Guid libraryId,             string? search = default,
            int? pageSize = default,
            string? filtersAttributes = default,
            string? sortBy = default,
            string? sortOrder = default,
            int? page = null,
            global::System.Threading.CancellationToken cancellationToken = default);

    }
}