#nullable enable

namespace Mistral
{
    public partial interface IBetaWorkflowsExecutionsClient
    {
        /// <summary>
        /// Stream
        /// </summary>
        /// <param name="executionId"></param>
        /// <param name="eventSource"></param>
        /// <param name="lastEventId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mistral.ApiException"></exception>
        global::System.Collections.Generic.IAsyncEnumerable<global::Mistral.StreamV1WorkflowsExecutionsExecutionIdStreamGetResponse> StreamAsync(
            string executionId,
            global::Mistral.EventSource? eventSource = default,
            string? lastEventId = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}