
#nullable enable

namespace Mistral
{
    /// <summary>
    /// Attributes for workflow task failed events.
    /// </summary>
    public sealed partial class WorkflowTaskFailedAttributes
    {
        /// <summary>
        /// Unique identifier for the task within the workflow execution.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("task_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TaskId { get; set; }

        /// <summary>
        /// Details about the failure that caused the task to fail.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("failure")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Mistral.Failure Failure { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowTaskFailedAttributes" /> class.
        /// </summary>
        /// <param name="taskId">
        /// Unique identifier for the task within the workflow execution.
        /// </param>
        /// <param name="failure">
        /// Details about the failure that caused the task to fail.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WorkflowTaskFailedAttributes(
            string taskId,
            global::Mistral.Failure failure)
        {
            this.TaskId = taskId ?? throw new global::System.ArgumentNullException(nameof(taskId));
            this.Failure = failure ?? throw new global::System.ArgumentNullException(nameof(failure));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowTaskFailedAttributes" /> class.
        /// </summary>
        public WorkflowTaskFailedAttributes()
        {
        }
    }
}