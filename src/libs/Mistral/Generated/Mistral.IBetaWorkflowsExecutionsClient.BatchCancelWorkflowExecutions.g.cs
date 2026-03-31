#nullable enable

namespace Mistral
{
    public partial interface IBetaWorkflowsExecutionsClient
    {
        /// <summary>
        /// Batch Cancel Workflow Executions
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mistral.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Mistral.BatchExecutionResponse> BatchCancelWorkflowExecutionsAsync(

            global::Mistral.BatchExecutionBody request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Batch Cancel Workflow Executions
        /// </summary>
        /// <param name="executionIds">
        /// List of execution IDs to process
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Mistral.BatchExecutionResponse> BatchCancelWorkflowExecutionsAsync(
            global::System.Collections.Generic.IList<string> executionIds,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}