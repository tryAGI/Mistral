
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
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public global::System.Guid Id { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public string Name { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public global::System.DateTime CreatedAt { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public global::System.DateTime UpdatedAt { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("owner_id")]
        public global::System.Guid? OwnerId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("owner_type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public string OwnerType { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_size")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public int TotalSize { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("nb_documents")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public int NbDocuments { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chunk_size")]
        public int? ChunkSize { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("emoji")]
        public string? Emoji { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("generated_description")]
        public string? GeneratedDescription { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("org_sharing_role")]
        public string? OrgSharingRole { get; set; }

        /// <summary>
        /// Generated Name
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("generated_name")]
        public string? GeneratedName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LibraryOut" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
        /// <param name="ownerId"></param>
        /// <param name="ownerType"></param>
        /// <param name="totalSize"></param>
        /// <param name="nbDocuments"></param>
        /// <param name="chunkSize"></param>
        /// <param name="emoji"></param>
        /// <param name="description"></param>
        /// <param name="generatedDescription"></param>
        /// <param name="explicitUserMembersCount"></param>
        /// <param name="explicitWorkspaceMembersCount"></param>
        /// <param name="orgSharingRole"></param>
        /// <param name="generatedName">
        /// Generated Name
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LibraryOut(
            global::System.Guid id,
            string name,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            string ownerType,
            int totalSize,
            int nbDocuments,
            global::System.Guid? ownerId,
            int? chunkSize,
            string? emoji,
            string? description,
            string? generatedDescription,
            int? explicitUserMembersCount,
            int? explicitWorkspaceMembersCount,
            string? orgSharingRole,
            string? generatedName)
        {
            this.Id = id;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.OwnerType = ownerType ?? throw new global::System.ArgumentNullException(nameof(ownerType));
            this.TotalSize = totalSize;
            this.NbDocuments = nbDocuments;
            this.OwnerId = ownerId;
            this.ChunkSize = chunkSize;
            this.Emoji = emoji;
            this.Description = description;
            this.GeneratedDescription = generatedDescription;
            this.ExplicitUserMembersCount = explicitUserMembersCount;
            this.ExplicitWorkspaceMembersCount = explicitWorkspaceMembersCount;
            this.OrgSharingRole = orgSharingRole;
            this.GeneratedName = generatedName;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LibraryOut" /> class.
        /// </summary>
        public LibraryOut()
        {
        }
    }
}