#nullable enable

namespace Mistral
{
    public partial interface IBetaLibrariesAccessesClient
    {
        /// <summary>
        /// Create or update an access level.<br/>
        /// Given a library id, you can create or update the access level of an entity. You have to be owner of the library to share a library. An owner cannot change their own role. A library cannot be shared outside of the organization.
        /// </summary>
        /// <param name="libraryId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mistral.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Mistral.SharingOut> CreateOrUpdateAnAccessLevelAsync(
            global::System.Guid libraryId,
            global::Mistral.SharingIn request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create or update an access level.<br/>
        /// Given a library id, you can create or update the access level of an entity. You have to be owner of the library to share a library. An owner cannot change their own role. A library cannot be shared outside of the organization.
        /// </summary>
        /// <param name="libraryId"></param>
        /// <param name="level"></param>
        /// <param name="orgId"></param>
        /// <param name="shareWithType">
        /// The type of entity, used to share a library.
        /// </param>
        /// <param name="shareWithUuid">
        /// The id of the entity (user, workspace or organization) to share with
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Mistral.SharingOut> CreateOrUpdateAnAccessLevelAsync(
            global::System.Guid libraryId,
            global::Mistral.ShareEnum level,
            global::System.Guid orgId,
            global::Mistral.EntityType shareWithType,
            global::System.Guid shareWithUuid,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}