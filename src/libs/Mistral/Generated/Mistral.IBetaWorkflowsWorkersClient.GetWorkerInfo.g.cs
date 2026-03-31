#nullable enable

namespace Mistral
{
    public partial interface IBetaWorkflowsWorkersClient
    {
        /// <summary>
        /// Get Worker Info
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mistral.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Mistral.WorkerInfo> GetWorkerInfoAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}