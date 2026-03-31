#nullable enable

namespace Mistral
{
    public partial interface IBetaWorkflowsClient
    {
        /// <summary>
        /// Unarchive Workflow
        /// </summary>
        /// <param name="workflowIdentifier"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mistral.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Mistral.WorkflowUnarchiveResponse> UnarchiveWorkflowAsync(
            string workflowIdentifier,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}