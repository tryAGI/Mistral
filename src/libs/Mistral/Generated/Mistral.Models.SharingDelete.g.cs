
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
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid OrgId { get; set; }

        /// <summary>
        /// The type of entity, used to share a library.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("share_with_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Mistral.JsonConverters.EntityTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Mistral.EntityType ShareWithType { get; set; }

        /// <summary>
        /// The id of the entity (user, workspace or organization) to share with
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("share_with_uuid")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid ShareWithUuid { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SharingDelete" /> class.
        /// </summary>
        /// <param name="orgId"></param>
        /// <param name="shareWithType">
        /// The type of entity, used to share a library.
        /// </param>
        /// <param name="shareWithUuid">
        /// The id of the entity (user, workspace or organization) to share with
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SharingDelete(
            global::System.Guid orgId,
            global::Mistral.EntityType shareWithType,
            global::System.Guid shareWithUuid)
        {
            this.OrgId = orgId;
            this.ShareWithType = shareWithType;
            this.ShareWithUuid = shareWithUuid;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SharingDelete" /> class.
        /// </summary>
        public SharingDelete()
        {
        }
    }
}