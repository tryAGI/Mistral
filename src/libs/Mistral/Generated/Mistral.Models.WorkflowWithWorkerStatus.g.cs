
#nullable enable

namespace Mistral
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WorkflowWithWorkerStatus
    {
        /// <summary>
        /// Unique identifier of the workflow
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid Id { get; set; }

        /// <summary>
        /// Name of the workflow
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Display name of the workflow
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("display_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DisplayName { get; set; }

        /// <summary>
        /// Type of the workflow
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Mistral.JsonConverters.WorkflowTypeJsonConverter))]
        public global::Mistral.WorkflowType Type { get; set; }

        /// <summary>
        /// Description of the workflow
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Customer ID of the workflow
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("customer_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid CustomerId { get; set; }

        /// <summary>
        /// Workspace ID of the workflow
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workspace_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid WorkspaceId { get; set; }

        /// <summary>
        /// Reserved namespace for shared workflows (e.g., 'shared:my-shared-workflow')
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("shared_namespace")]
        public string? SharedNamespace { get; set; }

        /// <summary>
        /// Whether the workflow is available in chat assistant<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("available_in_chat_assistant")]
        public bool? AvailableInChatAssistant { get; set; }

        /// <summary>
        /// Whether the workflow is technical (e.g. SDK-managed)<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_technical")]
        public bool? IsTechnical { get; set; }

        /// <summary>
        /// Whether the workflow is archived<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("archived")]
        public bool? Archived { get; set; }

        /// <summary>
        /// Whether the workflow is active
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("active")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Active { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowWithWorkerStatus" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier of the workflow
        /// </param>
        /// <param name="name">
        /// Name of the workflow
        /// </param>
        /// <param name="displayName">
        /// Display name of the workflow
        /// </param>
        /// <param name="customerId">
        /// Customer ID of the workflow
        /// </param>
        /// <param name="workspaceId">
        /// Workspace ID of the workflow
        /// </param>
        /// <param name="active">
        /// Whether the workflow is active
        /// </param>
        /// <param name="type">
        /// Type of the workflow
        /// </param>
        /// <param name="description">
        /// Description of the workflow
        /// </param>
        /// <param name="sharedNamespace">
        /// Reserved namespace for shared workflows (e.g., 'shared:my-shared-workflow')
        /// </param>
        /// <param name="availableInChatAssistant">
        /// Whether the workflow is available in chat assistant<br/>
        /// Default Value: false
        /// </param>
        /// <param name="isTechnical">
        /// Whether the workflow is technical (e.g. SDK-managed)<br/>
        /// Default Value: false
        /// </param>
        /// <param name="archived">
        /// Whether the workflow is archived<br/>
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WorkflowWithWorkerStatus(
            global::System.Guid id,
            string name,
            string displayName,
            global::System.Guid customerId,
            global::System.Guid workspaceId,
            bool active,
            global::Mistral.WorkflowType type,
            string? description,
            string? sharedNamespace,
            bool? availableInChatAssistant,
            bool? isTechnical,
            bool? archived)
        {
            this.Id = id;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.DisplayName = displayName ?? throw new global::System.ArgumentNullException(nameof(displayName));
            this.Type = type;
            this.Description = description;
            this.CustomerId = customerId;
            this.WorkspaceId = workspaceId;
            this.SharedNamespace = sharedNamespace;
            this.AvailableInChatAssistant = availableInChatAssistant;
            this.IsTechnical = isTechnical;
            this.Archived = archived;
            this.Active = active;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowWithWorkerStatus" /> class.
        /// </summary>
        public WorkflowWithWorkerStatus()
        {
        }
    }
}