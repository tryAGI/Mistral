#nullable enable

namespace Mistral
{
    public partial interface IBetaLibrariesDocumentsClient
    {
        /// <summary>
        /// List document in a given library.<br/>
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
        /// <param name="sortBy">
        /// Default Value: created_at
        /// </param>
        /// <param name="sortOrder">
        /// Default Value: desc
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mistral.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Mistral.ListDocumentOut> ListDocumentInAGivenLibraryAsync(
            global::System.Guid libraryId,
            string? search = default,
            int? pageSize = default,
            int? page = default,
            string? sortBy = default,
            string? sortOrder = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}