#nullable enable

namespace Mistral
{
    public partial interface IWorkflowsMetricsClient
    {
        /// <summary>
        /// Get Workflow Metrics<br/>
        /// Get comprehensive metrics for a specific workflow.<br/>
        /// Args:<br/>
        ///     workflow_name: The name of the workflow type to get metrics for<br/>
        ///     start_time: Optional start time filter (ISO 8601 format)<br/>
        ///     end_time: Optional end time filter (ISO 8601 format)<br/>
        /// Returns:<br/>
        ///     WorkflowMetrics: Dictionary containing metrics:<br/>
        ///         - execution_count: Total number of executions<br/>
        ///         - success_count: Number of successful executions<br/>
        ///         - error_count: Number of failed/terminated executions<br/>
        ///         - average_latency_ms: Average execution duration in milliseconds<br/>
        ///         - retry_rate: Proportion of workflows with retries<br/>
        ///         - latency_over_time: Time-series data of execution durations<br/>
        /// Example:<br/>
        ///     GET /v1/workflows/MyWorkflow/metrics<br/>
        ///     GET /v1/workflows/MyWorkflow/metrics?start_time=2025-01-01T00:00:00Z<br/>
        ///     GET /v1/workflows/MyWorkflow/metrics?start_time=2025-01-01T00:00:00Z&amp;end_time=2025-12-31T23:59:59Z
        /// </summary>
        /// <param name="workflowName"></param>
        /// <param name="startTime">
        /// Filter workflows started after this time (ISO 8601)
        /// </param>
        /// <param name="endTime">
        /// Filter workflows started before this time (ISO 8601)
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mistral.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Mistral.WorkflowMetrics> GetWorkflowMetricsAsync(
            string workflowName,
            global::System.DateTime? startTime = default,
            global::System.DateTime? endTime = default,
            global::Mistral.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}