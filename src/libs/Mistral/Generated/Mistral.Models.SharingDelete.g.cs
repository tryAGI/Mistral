
#nullable enable

namespace Mistral
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SharingDelete
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("org_id")]
        public global::System.Guid? OrgId { get; set; }

        /// <summary>
        /// The id of the entity (user, workspace or organization) to share with
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("share_with_uuid")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid ShareWithUuid { get; set; }

        /// <summary>
        /// The type of entity, used to share a library.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("share_with_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Mistral.JsonConverters.EntityTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Mistral.EntityType ShareWithType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SharingDelete" /> class.
        /// </summary>
        /// <param name="shareWithUuid">
        /// The id of the entity (user, workspace or organization) to share with
        /// </param>
        /// <param name="shareWithType">
        /// The type of entity, used to share a library.
        /// </param>
        /// <param name="orgId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SharingDelete(
            global::System.Guid shareWithUuid,
            global::Mistral.EntityType shareWithType,
            global::System.Guid? orgId)
        {
            this.OrgId = orgId;
            this.ShareWithUuid = shareWithUuid;
            this.ShareWithType = shareWithType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SharingDelete" /> class.
        /// </summary>
        public SharingDelete()
        {
        }
    }
}