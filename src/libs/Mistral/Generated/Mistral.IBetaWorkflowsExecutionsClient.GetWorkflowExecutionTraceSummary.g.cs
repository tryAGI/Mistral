#nullable enable

namespace Mistral
{
    public partial interface IBetaWorkflowsExecutionsClient
    {
        /// <summary>
        /// Get Workflow Execution Trace Summary
        /// </summary>
        /// <param name="executionId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mistral.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Mistral.WorkflowExecutionTraceSummaryResponse> GetWorkflowExecutionTraceSummaryAsync(
            string executionId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}