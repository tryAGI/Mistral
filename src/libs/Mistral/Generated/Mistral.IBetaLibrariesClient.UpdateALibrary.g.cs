#nullable enable

namespace Mistral
{
    public partial interface IBetaLibrariesClient
    {
        /// <summary>
        /// Update a library.<br/>
        /// Given a library id, you can update the name and description.
        /// </summary>
        /// <param name="libraryId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mistral.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Mistral.LibraryOut> UpdateALibraryAsync(
            global::System.Guid libraryId,
            global::Mistral.LibraryInUpdate request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Update a library.<br/>
        /// Given a library id, you can update the name and description.
        /// </summary>
        /// <param name="libraryId"></param>
        /// <param name="description"></param>
        /// <param name="name"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Mistral.LibraryOut> UpdateALibraryAsync(
            global::System.Guid libraryId,
            string? description = default,
            string? name = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}