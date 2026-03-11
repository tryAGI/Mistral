
#nullable enable

namespace Mistral
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CompletionFTModelOut
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public string Id { get; set; } = default!;

        /// <summary>
        /// Default Value: model
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        public string? Object { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public int Created { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("owned_by")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public string OwnedBy { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workspace_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public string WorkspaceId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("root")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public string Root { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("root_version")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public string RootVersion { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("archived")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public bool Archived { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("capabilities")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public global::Mistral.FTModelCapabilitiesOut Capabilities { get; set; } = default!;

        /// <summary>
        /// Default Value: 32768
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_context_length")]
        public int? MaxContextLength { get; set; }

        /// <summary>
        /// Default Value: []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("aliases")]
        public global::System.Collections.Generic.IList<string>? Aliases { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("job")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public global::System.Guid Job { get; set; } = default!;

        /// <summary>
        /// Default Value: completion
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_type")]
        public string? ModelType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CompletionFTModelOut" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="object">
        /// Default Value: model
        /// </param>
        /// <param name="created"></param>
        /// <param name="ownedBy"></param>
        /// <param name="workspaceId"></param>
        /// <param name="root"></param>
        /// <param name="rootVersion"></param>
        /// <param name="archived"></param>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="capabilities"></param>
        /// <param name="maxContextLength">
        /// Default Value: 32768
        /// </param>
        /// <param name="aliases">
        /// Default Value: []
        /// </param>
        /// <param name="job"></param>
        /// <param name="modelType">
        /// Default Value: completion
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CompletionFTModelOut(
            string id,
            int created,
            string ownedBy,
            string workspaceId,
            string root,
            string rootVersion,
            bool archived,
            global::Mistral.FTModelCapabilitiesOut capabilities,
            global::System.Guid job,
            string? @object,
            string? name,
            string? description,
            int? maxContextLength,
            global::System.Collections.Generic.IList<string>? aliases,
            string? modelType)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Created = created;
            this.OwnedBy = ownedBy ?? throw new global::System.ArgumentNullException(nameof(ownedBy));
            this.WorkspaceId = workspaceId ?? throw new global::System.ArgumentNullException(nameof(workspaceId));
            this.Root = root ?? throw new global::System.ArgumentNullException(nameof(root));
            this.RootVersion = rootVersion ?? throw new global::System.ArgumentNullException(nameof(rootVersion));
            this.Archived = archived;
            this.Capabilities = capabilities ?? throw new global::System.ArgumentNullException(nameof(capabilities));
            this.Job = job;
            this.Object = @object;
            this.Name = name;
            this.Description = description;
            this.MaxContextLength = maxContextLength;
            this.Aliases = aliases;
            this.ModelType = modelType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CompletionFTModelOut" /> class.
        /// </summary>
        public CompletionFTModelOut()
        {
        }
    }
}