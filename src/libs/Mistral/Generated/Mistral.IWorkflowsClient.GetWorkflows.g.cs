#nullable enable

namespace Mistral
{
    public partial interface IWorkflowsClient
    {
        /// <summary>
        /// Get Workflows
        /// </summary>
        /// <param name="activeOnly">
        /// Whether to only return active workflows<br/>
        /// Default Value: false
        /// </param>
        /// <param name="includeShared">
        /// Whether to include shared workflows<br/>
        /// Default Value: true
        /// </param>
        /// <param name="availableInChatAssistant">
        /// Whether to only return workflows compatible with chat assistant
        /// </param>
        /// <param name="archived">
        /// Filter by archived state. False=exclude archived, True=only archived, None=include all
        /// </param>
        /// <param name="cursor">
        /// The cursor for pagination
        /// </param>
        /// <param name="limit">
        /// The maximum number of workflows to return<br/>
        /// Default Value: 50
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mistral.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Mistral.WorkflowListResponse> GetWorkflowsAsync(
            bool? activeOnly = default,
            bool? includeShared = default,
            bool? availableInChatAssistant = default,
            bool? archived = default,
            global::System.Guid? cursor = default,
            int? limit = default,
            global::Mistral.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}