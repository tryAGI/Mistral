#nullable enable

namespace Mistral
{
    public partial interface IBetaWorkflowsExecutionsClient
    {
        /// <summary>
        /// Get Workflow Execution History
        /// </summary>
        /// <param name="executionId"></param>
        /// <param name="decodePayloads">
        /// Default Value: false
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mistral.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> GetWorkflowExecutionHistoryAsync(
            string executionId,
            bool? decodePayloads = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}