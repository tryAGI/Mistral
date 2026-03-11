#nullable enable

namespace Mistral
{
    public partial interface IBetaLibrariesClient
    {
        /// <summary>
        /// Detailed information about a specific Library.<br/>
        /// Given a library id, details information about that Library.
        /// </summary>
        /// <param name="libraryId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mistral.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Mistral.LibraryOut> DetailedInformationAboutASpecificLibraryAsync(
            global::System.Guid libraryId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}