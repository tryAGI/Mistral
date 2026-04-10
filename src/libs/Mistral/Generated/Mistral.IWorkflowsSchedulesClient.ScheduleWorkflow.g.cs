#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

namespace Mistral
{
    public partial interface IWorkflowsSchedulesClient
    {
        /// <summary>
        /// Schedule Workflow
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mistral.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Mistral.WorkflowScheduleResponse> ScheduleWorkflowAsync(

            global::Mistral.WorkflowScheduleRequest request,
            global::Mistral.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Schedule Workflow
        /// </summary>
        /// <param name="schedule">
        /// The schedule definition
        /// </param>
        /// <param name="workflowRegistrationId">
        /// The ID of the workflow registration to schedule
        /// </param>
        /// <param name="workflowVersionId">
        /// Deprecated: use workflow_registration_id
        /// </param>
        /// <param name="workflowIdentifier">
        /// The name or ID of the workflow to schedule
        /// </param>
        /// <param name="scheduleId">
        /// Allows you to specify a custom schedule ID. If not provided, a random ID will be generated.
        /// </param>
        /// <param name="deploymentName">
        /// Name of the deployment to route this schedule to
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Mistral.WorkflowScheduleResponse> ScheduleWorkflowAsync(
            global::Mistral.ScheduleDefinition schedule,
            global::System.Guid? workflowRegistrationId = default,
            global::System.Guid? workflowVersionId = default,
            string? workflowIdentifier = default,
            string? scheduleId = default,
            string? deploymentName = default,
            global::Mistral.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}