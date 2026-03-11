#nullable enable

namespace Mistral
{
    public partial interface IBetaLibrariesDocumentsClient
    {
        /// <summary>
        /// Reprocess a document.<br/>
        /// Given a library and a document in that library, reprocess that document, it will be billed again.
        /// </summary>
        /// <param name="libraryId"></param>
        /// <param name="documentId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mistral.ApiException"></exception>
        global::System.Threading.Tasks.Task ReprocessADocumentAsync(
            global::System.Guid libraryId,
            global::System.Guid documentId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}