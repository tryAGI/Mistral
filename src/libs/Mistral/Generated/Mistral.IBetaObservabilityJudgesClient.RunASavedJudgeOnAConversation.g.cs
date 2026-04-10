#nullable enable

namespace Mistral
{
    public partial interface IBetaObservabilityJudgesClient
    {
        /// <summary>
        /// Run a saved judge on a conversation
        /// </summary>
        /// <param name="judgeId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mistral.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Mistral.JudgeOutput> RunASavedJudgeOnAConversationAsync(
            global::System.Guid judgeId,

            global::Mistral.JudgeConversationRequest request,
            global::Mistral.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Run a saved judge on a conversation
        /// </summary>
        /// <param name="judgeId"></param>
        /// <param name="messages"></param>
        /// <param name="properties"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Mistral.JudgeOutput> RunASavedJudgeOnAConversationAsync(
            global::System.Guid judgeId,
            global::System.Collections.Generic.IList<object> messages,
            object? properties = default,
            global::Mistral.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}