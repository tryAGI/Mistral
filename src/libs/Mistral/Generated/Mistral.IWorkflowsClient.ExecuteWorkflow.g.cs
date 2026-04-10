#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

namespace Mistral
{
    public partial interface IWorkflowsClient
    {
        /// <summary>
        /// Execute Workflow
        /// </summary>
        /// <param name="workflowIdentifier"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mistral.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Mistral.AnyOf<global::Mistral.WorkflowExecutionResponse, global::Mistral.WorkflowExecutionSyncResponse>> ExecuteWorkflowAsync(
            string workflowIdentifier,

            global::Mistral.WorkflowExecutionRequest request,
            global::Mistral.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Execute Workflow
        /// </summary>
        /// <param name="workflowIdentifier"></param>
        /// <param name="executionId">
        /// Allows you to specify a custom execution ID. If not provided, a random ID will be generated.
        /// </param>
        /// <param name="input">
        /// The input to the workflow. This should be a dictionary that matches the workflow's input schema.
        /// </param>
        /// <param name="encodedInput">
        /// Encoded input to the workflow, used when payload encoding is enabled.
        /// </param>
        /// <param name="waitForResult">
        /// If true, wait for the workflow to complete and return the result directly.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="timeoutSeconds">
        /// Maximum time to wait for completion when wait_for_result is true.
        /// </param>
        /// <param name="customTracingAttributes"></param>
        /// <param name="deploymentName">
        /// Name of the deployment to route this execution to
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Mistral.AnyOf<global::Mistral.WorkflowExecutionResponse, global::Mistral.WorkflowExecutionSyncResponse>> ExecuteWorkflowAsync(
            string workflowIdentifier,
            string? executionId = default,
            object? input = default,
            global::Mistral.NetworkEncodedInput? encodedInput = default,
            bool? waitForResult = default,
            double? timeoutSeconds = default,
            global::System.Collections.Generic.Dictionary<string, string>? customTracingAttributes = default,
            string? deploymentName = default,
            global::Mistral.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}