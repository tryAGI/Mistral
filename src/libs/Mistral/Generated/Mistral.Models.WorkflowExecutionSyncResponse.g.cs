
#nullable enable

namespace Mistral
{
    /// <summary>
    /// Response model for synchronous workflow execution
    /// </summary>
    public sealed partial class WorkflowExecutionSyncResponse
    {
        /// <summary>
        /// Name of the workflow that was executed
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workflow_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string WorkflowName { get; set; }

        /// <summary>
        /// ID of the workflow execution
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("execution_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ExecutionId { get; set; }

        /// <summary>
        /// The result of the workflow execution
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("result")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Result { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowExecutionSyncResponse" /> class.
        /// </summary>
        /// <param name="workflowName">
        /// Name of the workflow that was executed
        /// </param>
        /// <param name="executionId">
        /// ID of the workflow execution
        /// </param>
        /// <param name="result">
        /// The result of the workflow execution
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WorkflowExecutionSyncResponse(
            string workflowName,
            string executionId,
            object result)
        {
            this.WorkflowName = workflowName ?? throw new global::System.ArgumentNullException(nameof(workflowName));
            this.ExecutionId = executionId ?? throw new global::System.ArgumentNullException(nameof(executionId));
            this.Result = result ?? throw new global::System.ArgumentNullException(nameof(result));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowExecutionSyncResponse" /> class.
        /// </summary>
        public WorkflowExecutionSyncResponse()
        {
        }
    }
}