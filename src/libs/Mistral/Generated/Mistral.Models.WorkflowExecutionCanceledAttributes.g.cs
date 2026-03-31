
#nullable enable

namespace Mistral
{
    /// <summary>
    /// Attributes for workflow execution canceled events.
    /// </summary>
    public sealed partial class WorkflowExecutionCanceledAttributes
    {
        /// <summary>
        /// Unique identifier for the task within the workflow execution.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("task_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TaskId { get; set; }

        /// <summary>
        /// Optional reason provided for the cancellation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reason")]
        public string? Reason { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowExecutionCanceledAttributes" /> class.
        /// </summary>
        /// <param name="taskId">
        /// Unique identifier for the task within the workflow execution.
        /// </param>
        /// <param name="reason">
        /// Optional reason provided for the cancellation.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WorkflowExecutionCanceledAttributes(
            string taskId,
            string? reason)
        {
            this.TaskId = taskId ?? throw new global::System.ArgumentNullException(nameof(taskId));
            this.Reason = reason;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowExecutionCanceledAttributes" /> class.
        /// </summary>
        public WorkflowExecutionCanceledAttributes()
        {
        }
    }
}