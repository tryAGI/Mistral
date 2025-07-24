#nullable enable

namespace Mistral
{
    public partial interface IBetaLibrariesClient
    {
        /// <summary>
        /// Create a new Library.<br/>
        /// Create a new Library, you will be marked as the owner and only you will have the possibility to share it with others. When first created this will only be accessible by you.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mistral.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Mistral.LibraryOut> CreateANewLibraryAsync(
            global::Mistral.LibraryIn request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create a new Library.<br/>
        /// Create a new Library, you will be marked as the owner and only you will have the possibility to share it with others. When first created this will only be accessible by you.
        /// </summary>
        /// <param name="chunkSize"></param>
        /// <param name="description"></param>
        /// <param name="name"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Mistral.LibraryOut> CreateANewLibraryAsync(
            string name,
            int? chunkSize = default,
            string? description = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}