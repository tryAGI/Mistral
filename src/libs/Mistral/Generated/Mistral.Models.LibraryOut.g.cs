
#nullable enable

namespace Mistral
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LibraryOut
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chunk_size")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int? ChunkSize { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("emoji")]
        public string? Emoji { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("explicit_user_members_count")]
        public int? ExplicitUserMembersCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("explicit_workspace_members_count")]
        public int? ExplicitWorkspaceMembersCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("generated_description")]
        public string? GeneratedDescription { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("generated_name")]
        public string? GeneratedName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("nb_documents")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int NbDocuments { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("org_sharing_role")]
        public string? OrgSharingRole { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("owner_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid OwnerId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("owner_type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string OwnerType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_size")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TotalSize { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LibraryOut" /> class.
        /// </summary>
        /// <param name="chunkSize"></param>
        /// <param name="createdAt"></param>
        /// <param name="description"></param>
        /// <param name="emoji"></param>
        /// <param name="explicitUserMembersCount"></param>
        /// <param name="explicitWorkspaceMembersCount"></param>
        /// <param name="generatedDescription"></param>
        /// <param name="generatedName"></param>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="nbDocuments"></param>
        /// <param name="orgSharingRole"></param>
        /// <param name="ownerId"></param>
        /// <param name="ownerType"></param>
        /// <param name="totalSize"></param>
        /// <param name="updatedAt"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LibraryOut(
            int? chunkSize,
            global::System.DateTime createdAt,
            global::System.Guid id,
            string name,
            int nbDocuments,
            global::System.Guid ownerId,
            string ownerType,
            int totalSize,
            global::System.DateTime updatedAt,
            string? description,
            string? emoji,
            int? explicitUserMembersCount,
            int? explicitWorkspaceMembersCount,
            string? generatedDescription,
            string? generatedName,
            string? orgSharingRole)
        {
            this.ChunkSize = chunkSize;
            this.CreatedAt = createdAt;
            this.Id = id;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.NbDocuments = nbDocuments;
            this.OwnerId = ownerId;
            this.OwnerType = ownerType ?? throw new global::System.ArgumentNullException(nameof(ownerType));
            this.TotalSize = totalSize;
            this.UpdatedAt = updatedAt;
            this.Description = description;
            this.Emoji = emoji;
            this.ExplicitUserMembersCount = explicitUserMembersCount;
            this.ExplicitWorkspaceMembersCount = explicitWorkspaceMembersCount;
            this.GeneratedDescription = generatedDescription;
            this.GeneratedName = generatedName;
            this.OrgSharingRole = orgSharingRole;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LibraryOut" /> class.
        /// </summary>
        public LibraryOut()
        {
        }
    }
}