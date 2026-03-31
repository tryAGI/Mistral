#nullable enable

namespace Mistral
{
    public partial interface IBetaWorkflowsClient
    {
        /// <summary>
        /// Get Workflow Registrations
        /// </summary>
        /// <param name="workflowId">
        /// The workflow ID to filter by
        /// </param>
        /// <param name="taskQueue">
        /// The task queue to filter by
        /// </param>
        /// <param name="activeOnly">
        /// Whether to only return active workflows versions<br/>
        /// Default Value: false
        /// </param>
        /// <param name="includeShared">
        /// Whether to include shared workflow versions<br/>
        /// Default Value: true
        /// </param>
        /// <param name="workflowSearch">
        /// The workflow name to filter by
        /// </param>
        /// <param name="archived">
        /// Filter by archived state. False=exclude archived, True=only archived, None=include all
        /// </param>
        /// <param name="withWorkflow">
        /// Whether to include the workflow definition<br/>
        /// Default Value: false
        /// </param>
        /// <param name="availableInChatAssistant">
        /// Whether to only return workflows compatible with chat assistant
        /// </param>
        /// <param name="limit">
        /// The maximum number of workflows versions to return<br/>
        /// Default Value: 50
        /// </param>
        /// <param name="cursor">
        /// The cursor for pagination
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mistral.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Mistral.WorkflowRegistrationListResponse> GetWorkflowRegistrationsAsync(
            global::System.Guid? workflowId = default,
            string? taskQueue = default,
            bool? activeOnly = default,
            bool? includeShared = default,
            string? workflowSearch = default,
            bool? archived = default,
            bool? withWorkflow = default,
            bool? availableInChatAssistant = default,
            int? limit = default,
            global::System.Guid? cursor = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}