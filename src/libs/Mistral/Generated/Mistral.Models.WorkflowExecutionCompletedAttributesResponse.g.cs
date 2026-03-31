
#nullable enable

namespace Mistral
{
    /// <summary>
    /// Attributes for workflow execution completed events.
    /// </summary>
    public sealed partial class WorkflowExecutionCompletedAttributesResponse
    {
        /// <summary>
        /// Unique identifier for the task within the workflow execution.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("task_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TaskId { get; set; }

        /// <summary>
        /// The final result returned by the workflow.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("result")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Mistral.JSONPayloadResponse Result { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowExecutionCompletedAttributesResponse" /> class.
        /// </summary>
        /// <param name="taskId">
        /// Unique identifier for the task within the workflow execution.
        /// </param>
        /// <param name="result">
        /// The final result returned by the workflow.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WorkflowExecutionCompletedAttributesResponse(
            string taskId,
            global::Mistral.JSONPayloadResponse result)
        {
            this.TaskId = taskId ?? throw new global::System.ArgumentNullException(nameof(taskId));
            this.Result = result ?? throw new global::System.ArgumentNullException(nameof(result));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowExecutionCompletedAttributesResponse" /> class.
        /// </summary>
        public WorkflowExecutionCompletedAttributesResponse()
        {
        }
    }
}