#nullable enable

namespace Mistral
{
    public partial interface IWorkflowsExecutionsClient
    {
        /// <summary>
        /// Reset Workflow
        /// </summary>
        /// <param name="executionId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mistral.ApiException"></exception>
        global::System.Threading.Tasks.Task ResetWorkflowAsync(
            string executionId,

            global::Mistral.ResetInvocationBody request,
            global::Mistral.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Reset Workflow
        /// </summary>
        /// <param name="executionId"></param>
        /// <param name="eventId">
        /// The event ID to reset the workflow execution to
        /// </param>
        /// <param name="reason">
        /// Reason for resetting the workflow execution
        /// </param>
        /// <param name="excludeSignals">
        /// Whether to exclude signals that happened after the reset point<br/>
        /// Default Value: false
        /// </param>
        /// <param name="excludeUpdates">
        /// Whether to exclude updates that happened after the reset point<br/>
        /// Default Value: false
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task ResetWorkflowAsync(
            string executionId,
            int eventId,
            string? reason = default,
            bool? excludeSignals = default,
            bool? excludeUpdates = default,
            global::Mistral.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}