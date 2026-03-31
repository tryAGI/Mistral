
#nullable enable

namespace Mistral
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WorkflowBasicDefinition
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid Id { get; set; }

        /// <summary>
        /// The name of the workflow
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// The display name of the workflow
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("display_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DisplayName { get; set; }

        /// <summary>
        /// A description of the workflow
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Workflow metadata
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public global::Mistral.WorkflowMetadata? Metadata { get; set; }

        /// <summary>
        /// Whether the workflow is archived
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("archived")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Archived { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowBasicDefinition" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name">
        /// The name of the workflow
        /// </param>
        /// <param name="displayName">
        /// The display name of the workflow
        /// </param>
        /// <param name="archived">
        /// Whether the workflow is archived
        /// </param>
        /// <param name="description">
        /// A description of the workflow
        /// </param>
        /// <param name="metadata">
        /// Workflow metadata
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WorkflowBasicDefinition(
            global::System.Guid id,
            string name,
            string displayName,
            bool archived,
            string? description,
            global::Mistral.WorkflowMetadata? metadata)
        {
            this.Id = id;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.DisplayName = displayName ?? throw new global::System.ArgumentNullException(nameof(displayName));
            this.Description = description;
            this.Metadata = metadata;
            this.Archived = archived;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowBasicDefinition" /> class.
        /// </summary>
        public WorkflowBasicDefinition()
        {
        }
    }
}