
#nullable enable

namespace Mistral
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WorkflowExecutionTraceEventsResponse
    {
        /// <summary>
        /// The name of the workflow
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workflow_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string WorkflowName { get; set; }

        /// <summary>
        /// The ID of the workflow execution
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("execution_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ExecutionId { get; set; }

        /// <summary>
        /// The parent execution ID of the workflow execution
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parent_execution_id")]
        public string? ParentExecutionId { get; set; }

        /// <summary>
        /// The root execution ID of the workflow execution
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("root_execution_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RootExecutionId { get; set; }

        /// <summary>
        /// The status of the workflow execution
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        public global::Mistral.WorkflowExecutionStatus? Status { get; set; }

        /// <summary>
        /// The start time of the workflow execution
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_time")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime StartTime { get; set; }

        /// <summary>
        /// The end time of the workflow execution, if available
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_time")]
        public global::System.DateTime? EndTime { get; set; }

        /// <summary>
        /// The total duration of the trace in milliseconds
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_duration_ms")]
        public int? TotalDurationMs { get; set; }

        /// <summary>
        /// The result of the workflow execution, if available
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("result")]
        public object? Result { get; set; }

        /// <summary>
        /// The events of the workflow execution
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("events")]
        public global::System.Collections.Generic.IList<global::Mistral.AnyOf<global::Mistral.WorkflowExecutionTraceEvent, global::Mistral.WorkflowExecutionProgressTraceEvent>>? Events { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowExecutionTraceEventsResponse" /> class.
        /// </summary>
        /// <param name="workflowName">
        /// The name of the workflow
        /// </param>
        /// <param name="executionId">
        /// The ID of the workflow execution
        /// </param>
        /// <param name="rootExecutionId">
        /// The root execution ID of the workflow execution
        /// </param>
        /// <param name="startTime">
        /// The start time of the workflow execution
        /// </param>
        /// <param name="parentExecutionId">
        /// The parent execution ID of the workflow execution
        /// </param>
        /// <param name="status">
        /// The status of the workflow execution
        /// </param>
        /// <param name="endTime">
        /// The end time of the workflow execution, if available
        /// </param>
        /// <param name="totalDurationMs">
        /// The total duration of the trace in milliseconds
        /// </param>
        /// <param name="result">
        /// The result of the workflow execution, if available
        /// </param>
        /// <param name="events">
        /// The events of the workflow execution
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WorkflowExecutionTraceEventsResponse(
            string workflowName,
            string executionId,
            string rootExecutionId,
            global::System.DateTime startTime,
            string? parentExecutionId,
            global::Mistral.WorkflowExecutionStatus? status,
            global::System.DateTime? endTime,
            int? totalDurationMs,
            object? result,
            global::System.Collections.Generic.IList<global::Mistral.AnyOf<global::Mistral.WorkflowExecutionTraceEvent, global::Mistral.WorkflowExecutionProgressTraceEvent>>? events)
        {
            this.WorkflowName = workflowName ?? throw new global::System.ArgumentNullException(nameof(workflowName));
            this.ExecutionId = executionId ?? throw new global::System.ArgumentNullException(nameof(executionId));
            this.ParentExecutionId = parentExecutionId;
            this.RootExecutionId = rootExecutionId ?? throw new global::System.ArgumentNullException(nameof(rootExecutionId));
            this.Status = status;
            this.StartTime = startTime;
            this.EndTime = endTime;
            this.TotalDurationMs = totalDurationMs;
            this.Result = result;
            this.Events = events;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowExecutionTraceEventsResponse" /> class.
        /// </summary>
        public WorkflowExecutionTraceEventsResponse()
        {
        }
    }
}