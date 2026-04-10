#nullable enable

namespace Mistral
{
    public partial interface IWorkflowsExecutionsClient
    {
        /// <summary>
        /// Signal Workflow Execution
        /// </summary>
        /// <param name="executionId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mistral.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Mistral.SignalWorkflowResponse> SignalWorkflowExecutionAsync(
            string executionId,

            global::Mistral.SignalInvocationBody request,
            global::Mistral.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Signal Workflow Execution
        /// </summary>
        /// <param name="executionId"></param>
        /// <param name="name">
        /// The name of the signal to send
        /// </param>
        /// <param name="input">
        /// Input data for the signal, matching its schema
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Mistral.SignalWorkflowResponse> SignalWorkflowExecutionAsync(
            string executionId,
            string name,
            global::Mistral.AnyOf<global::Mistral.NetworkEncodedInput, object, object>? input = default,
            global::Mistral.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}