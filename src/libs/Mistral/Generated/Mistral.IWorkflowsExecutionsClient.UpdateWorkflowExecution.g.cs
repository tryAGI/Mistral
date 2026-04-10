#nullable enable

namespace Mistral
{
    public partial interface IWorkflowsExecutionsClient
    {
        /// <summary>
        /// Update Workflow Execution
        /// </summary>
        /// <param name="executionId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mistral.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Mistral.UpdateWorkflowResponse> UpdateWorkflowExecutionAsync(
            string executionId,

            global::Mistral.UpdateInvocationBody request,
            global::Mistral.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Workflow Execution
        /// </summary>
        /// <param name="executionId"></param>
        /// <param name="name">
        /// The name of the update to request
        /// </param>
        /// <param name="input">
        /// Input data for the update, matching its schema
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Mistral.UpdateWorkflowResponse> UpdateWorkflowExecutionAsync(
            string executionId,
            string name,
            global::Mistral.AnyOf<global::Mistral.NetworkEncodedInput, object, object>? input = default,
            global::Mistral.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}