#nullable enable

namespace Mistral
{
    public partial interface IWorkflowsRunsClient
    {
        /// <summary>
        /// List Runs
        /// </summary>
        /// <param name="workflowIdentifier">
        /// Filter by workflow name or id
        /// </param>
        /// <param name="search">
        /// Search by workflow name, display name or id
        /// </param>
        /// <param name="status">
        /// Filter by workflow status
        /// </param>
        /// <param name="pageSize">
        /// Number of items per page<br/>
        /// Default Value: 50
        /// </param>
        /// <param name="nextPageToken">
        /// Token for the next page of results
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mistral.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Mistral.WorkflowExecutionListResponse> ListRunsAsync(
            string? workflowIdentifier = default,
            string? search = default,
            global::Mistral.AnyOf<global::Mistral.WorkflowExecutionStatus?, global::System.Collections.Generic.IList<global::Mistral.WorkflowExecutionStatus>, object>? status = default,
            int? pageSize = default,
            string? nextPageToken = default,
            global::Mistral.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}