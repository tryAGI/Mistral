#nullable enable

namespace Mistral
{
    public partial interface IBetaWorkflowsRunsClient
    {
        /// <summary>
        /// Get Run History
        /// </summary>
        /// <param name="runId"></param>
        /// <param name="decodePayloads">
        /// Default Value: false
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mistral.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> GetRunHistoryAsync(
            global::System.Guid runId,
            bool? decodePayloads = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}