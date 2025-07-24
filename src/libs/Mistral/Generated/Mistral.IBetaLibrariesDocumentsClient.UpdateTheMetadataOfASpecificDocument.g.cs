#nullable enable

namespace Mistral
{
    public partial interface IBetaLibrariesDocumentsClient
    {
        /// <summary>
        /// Update the metadata of a specific document.<br/>
        /// Given a library and a document in that library, update the name of that document.
        /// </summary>
        /// <param name="libraryId"></param>
        /// <param name="documentId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mistral.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Mistral.DocumentOut> UpdateTheMetadataOfASpecificDocumentAsync(
            global::System.Guid libraryId,
            global::System.Guid documentId,
            global::Mistral.DocumentUpdateIn request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Update the metadata of a specific document.<br/>
        /// Given a library and a document in that library, update the name of that document.
        /// </summary>
        /// <param name="libraryId"></param>
        /// <param name="documentId"></param>
        /// <param name="name"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Mistral.DocumentOut> UpdateTheMetadataOfASpecificDocumentAsync(
            global::System.Guid libraryId,
            global::System.Guid documentId,
            string? name = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}