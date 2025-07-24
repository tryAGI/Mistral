#nullable enable

namespace Mistral
{
    public partial interface IBetaLibrariesDocumentsClient
    {
        /// <summary>
        /// Retrieve the processing status of a specific document.<br/>
        /// Given a library and a document in that library, retrieve the processing status of that document.
        /// </summary>
        /// <param name="libraryId"></param>
        /// <param name="documentId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mistral.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Mistral.ProcessingStatusOut> RetrieveTheProcessingStatusOfASpecificDocumentAsync(
            global::System.Guid libraryId,
            global::System.Guid documentId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}