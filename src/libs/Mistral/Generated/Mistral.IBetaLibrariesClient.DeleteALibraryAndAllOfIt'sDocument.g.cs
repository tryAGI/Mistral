#nullable enable

namespace Mistral
{
    public partial interface IBetaLibrariesClient
    {
        /// <summary>
        /// Delete a library and all of it's document.<br/>
        /// Given a library id, deletes it together with all documents that have been uploaded to that library.
        /// </summary>
        /// <param name="libraryId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mistral.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Mistral.LibraryOut> DeleteALibraryAndAllOfIt'sDocumentAsync(
            global::System.Guid libraryId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}