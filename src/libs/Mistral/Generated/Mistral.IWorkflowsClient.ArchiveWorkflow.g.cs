#nullable enable

namespace Mistral
{
    public partial interface IWorkflowsClient
    {
        /// <summary>
        /// Archive Workflow
        /// </summary>
        /// <param name="workflowIdentifier"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mistral.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Mistral.WorkflowArchiveResponse> ArchiveWorkflowAsync(
            string workflowIdentifier,
            global::Mistral.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}