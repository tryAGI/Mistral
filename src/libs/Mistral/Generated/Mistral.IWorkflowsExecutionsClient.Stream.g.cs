#nullable enable

namespace Mistral
{
    public partial interface IWorkflowsExecutionsClient
    {
        /// <summary>
        /// Stream
        /// </summary>
        /// <param name="executionId"></param>
        /// <param name="eventSource"></param>
        /// <param name="lastEventId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mistral.ApiException"></exception>
        global::System.Collections.Generic.IAsyncEnumerable<global::Mistral.StreamV1WorkflowsExecutionsExecutionIdStreamGetResponse> StreamAsync(
            string executionId,
            global::Mistral.EventSource? eventSource = default,
            string? lastEventId = default,
            global::Mistral.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}