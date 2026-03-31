#nullable enable

namespace Mistral
{
    public partial interface IBetaWorkflowsClient
    {
        /// <summary>
        /// Update Workflow
        /// </summary>
        /// <param name="workflowIdentifier"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mistral.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Mistral.WorkflowUpdateResponse> UpdateWorkflowAsync(
            string workflowIdentifier,

            global::Mistral.WorkflowUpdateRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Workflow
        /// </summary>
        /// <param name="workflowIdentifier"></param>
        /// <param name="displayName">
        /// New display name value
        /// </param>
        /// <param name="description">
        /// New description value
        /// </param>
        /// <param name="availableInChatAssistant">
        /// Whether to make the workflow available in the chat assistant
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Mistral.WorkflowUpdateResponse> UpdateWorkflowAsync(
            string workflowIdentifier,
            string? displayName = default,
            string? description = default,
            bool? availableInChatAssistant = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}