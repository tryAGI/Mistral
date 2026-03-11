#nullable enable

namespace Mistral
{
    public partial interface IBetaLibrariesDocumentsClient
    {
        /// <summary>
        /// Delete a document.<br/>
        /// Given a library and a document in that library, delete that document. The document will be deleted from the library and the search index.
        /// </summary>
        /// <param name="libraryId"></param>
        /// <param name="documentId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mistral.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteADocumentAsync(
            global::System.Guid libraryId,
            global::System.Guid documentId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}