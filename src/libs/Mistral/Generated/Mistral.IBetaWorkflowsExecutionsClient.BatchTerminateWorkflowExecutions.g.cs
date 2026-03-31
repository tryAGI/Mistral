#nullable enable

namespace Mistral
{
    public partial interface IBetaWorkflowsExecutionsClient
    {
        /// <summary>
        /// Batch Terminate Workflow Executions
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mistral.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Mistral.BatchExecutionResponse> BatchTerminateWorkflowExecutionsAsync(

            global::Mistral.BatchExecutionBody request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Batch Terminate Workflow Executions
        /// </summary>
        /// <param name="executionIds">
        /// List of execution IDs to process
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Mistral.BatchExecutionResponse> BatchTerminateWorkflowExecutionsAsync(
            global::System.Collections.Generic.IList<string> executionIds,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}