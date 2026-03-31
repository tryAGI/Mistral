#nullable enable

namespace Mistral
{
    public partial interface IBetaWorkflowsExecutionsClient
    {
        /// <summary>
        /// Query Workflow Execution
        /// </summary>
        /// <param name="executionId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mistral.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Mistral.QueryWorkflowResponse> QueryWorkflowExecutionAsync(
            string executionId,

            global::Mistral.QueryInvocationBody request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Query Workflow Execution
        /// </summary>
        /// <param name="executionId"></param>
        /// <param name="name">
        /// The name of the query to request
        /// </param>
        /// <param name="input">
        /// Input data for the query, matching its schema
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Mistral.QueryWorkflowResponse> QueryWorkflowExecutionAsync(
            string executionId,
            string name,
            global::Mistral.AnyOf<global::Mistral.NetworkEncodedInput, object, object>? input = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}