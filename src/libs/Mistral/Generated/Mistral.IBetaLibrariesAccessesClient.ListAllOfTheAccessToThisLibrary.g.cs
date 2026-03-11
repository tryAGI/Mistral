#nullable enable

namespace Mistral
{
    public partial interface IBetaLibrariesAccessesClient
    {
        /// <summary>
        /// List all of the access to this library.<br/>
        /// Given a library, list all of the Entity that have access and to what level.
        /// </summary>
        /// <param name="libraryId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mistral.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Mistral.ListSharingOut> ListAllOfTheAccessToThisLibraryAsync(
            global::System.Guid libraryId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}