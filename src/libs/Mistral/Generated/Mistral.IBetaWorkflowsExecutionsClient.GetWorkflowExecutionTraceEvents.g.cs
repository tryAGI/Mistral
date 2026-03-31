#nullable enable

namespace Mistral
{
    public partial interface IBetaWorkflowsExecutionsClient
    {
        /// <summary>
        /// Get Workflow Execution Trace Events
        /// </summary>
        /// <param name="executionId"></param>
        /// <param name="mergeSameIdEvents">
        /// Default Value: false
        /// </param>
        /// <param name="includeInternalEvents">
        /// Default Value: false
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mistral.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Mistral.WorkflowExecutionTraceEventsResponse> GetWorkflowExecutionTraceEventsAsync(
            string executionId,
            bool? mergeSameIdEvents = default,
            bool? includeInternalEvents = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}