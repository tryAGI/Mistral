#nullable enable

namespace Mistral
{
    public partial interface IBetaWorkflowsSchedulesClient
    {
        /// <summary>
        /// Unschedule Workflow
        /// </summary>
        /// <param name="scheduleId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mistral.ApiException"></exception>
        global::System.Threading.Tasks.Task UnscheduleWorkflowAsync(
            string scheduleId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}