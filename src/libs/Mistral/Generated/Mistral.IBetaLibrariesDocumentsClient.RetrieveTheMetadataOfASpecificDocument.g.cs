#nullable enable

namespace Mistral
{
    public partial interface IBetaLibrariesDocumentsClient
    {
        /// <summary>
        /// Retrieve the metadata of a specific document.<br/>
        /// Given a library and a document in this library, you can retrieve the metadata of that document.
        /// </summary>
        /// <param name="libraryId"></param>
        /// <param name="documentId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mistral.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Mistral.DocumentOut> RetrieveTheMetadataOfASpecificDocumentAsync(
            global::System.Guid libraryId,
            global::System.Guid documentId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}