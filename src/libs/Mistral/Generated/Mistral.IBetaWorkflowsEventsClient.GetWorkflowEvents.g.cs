#nullable enable

namespace Mistral
{
    public partial interface IBetaWorkflowsEventsClient
    {
        /// <summary>
        /// Get Workflow Events
        /// </summary>
        /// <param name="rootWorkflowExecId">
        /// Execution ID of the root workflow that initiated this execution chain.
        /// </param>
        /// <param name="workflowExecId">
        /// Execution ID of the workflow that emitted this event.
        /// </param>
        /// <param name="workflowRunId">
        /// Run ID of the workflow that emitted this event.
        /// </param>
        /// <param name="limit">
        /// Maximum number of events to return.<br/>
        /// Default Value: 100
        /// </param>
        /// <param name="cursor">
        /// Cursor for pagination.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mistral.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Mistral.ListWorkflowEventResponse> GetWorkflowEventsAsync(
            string? rootWorkflowExecId = default,
            string? workflowExecId = default,
            string? workflowRunId = default,
            int? limit = default,
            string? cursor = default,
            global::Mistral.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}