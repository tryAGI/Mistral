#nullable enable

namespace Mistral
{
    public partial interface IBetaWorkflowsRunsClient
    {
        /// <summary>
        /// Get Run
        /// </summary>
        /// <param name="runId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mistral.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Mistral.WorkflowExecutionResponse> GetRunAsync(
            global::System.Guid runId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}