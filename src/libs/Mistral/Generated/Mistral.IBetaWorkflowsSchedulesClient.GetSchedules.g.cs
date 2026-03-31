#nullable enable

namespace Mistral
{
    public partial interface IBetaWorkflowsSchedulesClient
    {
        /// <summary>
        /// Get Schedules
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mistral.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Mistral.WorkflowScheduleListResponse> GetSchedulesAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}