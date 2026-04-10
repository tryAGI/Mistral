#nullable enable

namespace Mistral
{
    public partial interface IBetaWorkflowsExecutionsClient
    {
        /// <summary>
        /// Get Workflow Execution Trace Otel
        /// </summary>
        /// <param name="executionId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mistral.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Mistral.WorkflowExecutionTraceOTelResponse> GetWorkflowExecutionTraceOtelAsync(
            string executionId,
            global::Mistral.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}