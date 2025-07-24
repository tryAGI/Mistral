
#nullable enable

namespace Mistral
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SharingOut
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("library_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid LibraryId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("org_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid OrgId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Role { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("share_with_type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ShareWithType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("share_with_uuid")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid ShareWithUuid { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_id")]
        public global::System.Guid? UserId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SharingOut" /> class.
        /// </summary>
        /// <param name="libraryId"></param>
        /// <param name="orgId"></param>
        /// <param name="role"></param>
        /// <param name="shareWithType"></param>
        /// <param name="shareWithUuid"></param>
        /// <param name="userId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SharingOut(
            global::System.Guid libraryId,
            global::System.Guid orgId,
            string role,
            string shareWithType,
            global::System.Guid shareWithUuid,
            global::System.Guid? userId)
        {
            this.LibraryId = libraryId;
            this.OrgId = orgId;
            this.Role = role ?? throw new global::System.ArgumentNullException(nameof(role));
            this.ShareWithType = shareWithType ?? throw new global::System.ArgumentNullException(nameof(shareWithType));
            this.ShareWithUuid = shareWithUuid;
            this.UserId = userId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SharingOut" /> class.
        /// </summary>
        public SharingOut()
        {
        }
    }
}