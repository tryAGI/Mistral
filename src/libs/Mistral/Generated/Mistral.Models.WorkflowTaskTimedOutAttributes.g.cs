
#nullable enable

namespace Mistral
{
    /// <summary>
    /// Attributes for workflow task timed out events.
    /// </summary>
    public sealed partial class WorkflowTaskTimedOutAttributes
    {
        /// <summary>
        /// Unique identifier for the task within the workflow execution.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("task_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TaskId { get; set; }

        /// <summary>
        /// The type of timeout that occurred (e.g., 'START_TO_CLOSE', 'SCHEDULE_TO_START').
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timeout_type")]
        public string? TimeoutType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowTaskTimedOutAttributes" /> class.
        /// </summary>
        /// <param name="taskId">
        /// Unique identifier for the task within the workflow execution.
        /// </param>
        /// <param name="timeoutType">
        /// The type of timeout that occurred (e.g., 'START_TO_CLOSE', 'SCHEDULE_TO_START').
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WorkflowTaskTimedOutAttributes(
            string taskId,
            string? timeoutType)
        {
            this.TaskId = taskId ?? throw new global::System.ArgumentNullException(nameof(taskId));
            this.TimeoutType = timeoutType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowTaskTimedOutAttributes" /> class.
        /// </summary>
        public WorkflowTaskTimedOutAttributes()
        {
        }
    }
}