#nullable enable

namespace Mistral
{
    public partial interface IWorkflowsClient
    {
        /// <summary>
        /// Get Workflow Registration
        /// </summary>
        /// <param name="workflowRegistrationId"></param>
        /// <param name="withWorkflow">
        /// Whether to include the workflow definition<br/>
        /// Default Value: false
        /// </param>
        /// <param name="includeShared">
        /// Whether to include shared workflow versions<br/>
        /// Default Value: true
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mistral.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Mistral.WorkflowRegistrationGetResponse> GetWorkflowRegistrationAsync(
            global::System.Guid workflowRegistrationId,
            bool? withWorkflow = default,
            bool? includeShared = default,
            global::Mistral.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}