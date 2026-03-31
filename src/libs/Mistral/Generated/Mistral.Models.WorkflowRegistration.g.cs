
#nullable enable

namespace Mistral
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WorkflowRegistration
    {
        /// <summary>
        /// Unique identifier of the workflow registration
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid Id { get; set; }

        /// <summary>
        /// Project name of the workflow
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("task_queue")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TaskQueue { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("definition")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Mistral.WorkflowCodeDefinition Definition { get; set; }

        /// <summary>
        /// Workflow ID of the workflow
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workflow_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid WorkflowId { get; set; }

        /// <summary>
        /// Workflow of the workflow registration
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workflow")]
        public global::Mistral.Workflow? Workflow { get; set; }

        /// <summary>
        /// Whether the workflow is compatible with chat assistant<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("compatible_with_chat_assistant")]
        public bool? CompatibleWithChatAssistant { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowRegistration" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier of the workflow registration
        /// </param>
        /// <param name="taskQueue">
        /// Project name of the workflow
        /// </param>
        /// <param name="definition"></param>
        /// <param name="workflowId">
        /// Workflow ID of the workflow
        /// </param>
        /// <param name="workflow">
        /// Workflow of the workflow registration
        /// </param>
        /// <param name="compatibleWithChatAssistant">
        /// Whether the workflow is compatible with chat assistant<br/>
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WorkflowRegistration(
            global::System.Guid id,
            string taskQueue,
            global::Mistral.WorkflowCodeDefinition definition,
            global::System.Guid workflowId,
            global::Mistral.Workflow? workflow,
            bool? compatibleWithChatAssistant)
        {
            this.Id = id;
            this.TaskQueue = taskQueue ?? throw new global::System.ArgumentNullException(nameof(taskQueue));
            this.Definition = definition ?? throw new global::System.ArgumentNullException(nameof(definition));
            this.WorkflowId = workflowId;
            this.Workflow = workflow;
            this.CompatibleWithChatAssistant = compatibleWithChatAssistant;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowRegistration" /> class.
        /// </summary>
        public WorkflowRegistration()
        {
        }
    }
}