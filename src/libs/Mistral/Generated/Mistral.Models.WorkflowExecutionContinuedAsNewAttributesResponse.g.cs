
#nullable enable

namespace Mistral
{
    /// <summary>
    /// Attributes for workflow execution continued-as-new events.
    /// </summary>
    public sealed partial class WorkflowExecutionContinuedAsNewAttributesResponse
    {
        /// <summary>
        /// Unique identifier for the task within the workflow execution.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("task_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TaskId { get; set; }

        /// <summary>
        /// The run ID of the new workflow execution that continues this workflow.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("new_execution_run_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string NewExecutionRunId { get; set; }

        /// <summary>
        /// The registered name of the continued workflow.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workflow_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string WorkflowName { get; set; }

        /// <summary>
        /// The input arguments passed to the new workflow execution.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Mistral.JSONPayloadResponse Input { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowExecutionContinuedAsNewAttributesResponse" /> class.
        /// </summary>
        /// <param name="taskId">
        /// Unique identifier for the task within the workflow execution.
        /// </param>
        /// <param name="newExecutionRunId">
        /// The run ID of the new workflow execution that continues this workflow.
        /// </param>
        /// <param name="workflowName">
        /// The registered name of the continued workflow.
        /// </param>
        /// <param name="input">
        /// The input arguments passed to the new workflow execution.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WorkflowExecutionContinuedAsNewAttributesResponse(
            string taskId,
            string newExecutionRunId,
            string workflowName,
            global::Mistral.JSONPayloadResponse input)
        {
            this.TaskId = taskId ?? throw new global::System.ArgumentNullException(nameof(taskId));
            this.NewExecutionRunId = newExecutionRunId ?? throw new global::System.ArgumentNullException(nameof(newExecutionRunId));
            this.WorkflowName = workflowName ?? throw new global::System.ArgumentNullException(nameof(workflowName));
            this.Input = input ?? throw new global::System.ArgumentNullException(nameof(input));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowExecutionContinuedAsNewAttributesResponse" /> class.
        /// </summary>
        public WorkflowExecutionContinuedAsNewAttributesResponse()
        {
        }
    }
}