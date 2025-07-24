#nullable enable

namespace Mistral
{
    public partial interface IBetaLibrariesAccessesClient
    {
        /// <summary>
        /// Delete an access level.<br/>
        /// Given a library id, you can delete the access level of an entity. An owner cannot delete it's own access. You have to be the owner of the library to delete an acces other than yours.
        /// </summary>
        /// <param name="libraryId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mistral.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Mistral.SharingOut> DeleteAnAccessLevelAsync(
            global::System.Guid libraryId,
            global::Mistral.SharingDelete request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Delete an access level.<br/>
        /// Given a library id, you can delete the access level of an entity. An owner cannot delete it's own access. You have to be the owner of the library to delete an acces other than yours.
        /// </summary>
        /// <param name="libraryId"></param>
        /// <param name="orgId"></param>
        /// <param name="shareWithType">
        /// The type of entity, used to share a library.
        /// </param>
        /// <param name="shareWithUuid">
        /// The id of the entity (user, workspace or organization) to share with
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Mistral.SharingOut> DeleteAnAccessLevelAsync(
            global::System.Guid libraryId,
            global::System.Guid orgId,
            global::Mistral.EntityType shareWithType,
            global::System.Guid shareWithUuid,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}