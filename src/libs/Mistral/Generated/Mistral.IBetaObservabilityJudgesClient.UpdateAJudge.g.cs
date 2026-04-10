#nullable enable

namespace Mistral
{
    public partial interface IBetaObservabilityJudgesClient
    {
        /// <summary>
        /// Update a judge
        /// </summary>
        /// <param name="judgeId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mistral.ApiException"></exception>
        global::System.Threading.Tasks.Task UpdateAJudgeAsync(
            global::System.Guid judgeId,

            global::Mistral.PutJudgeInSchema request,
            global::Mistral.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update a judge
        /// </summary>
        /// <param name="judgeId"></param>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="modelName"></param>
        /// <param name="output"></param>
        /// <param name="instructions"></param>
        /// <param name="tools"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task UpdateAJudgeAsync(
            global::System.Guid judgeId,
            string name,
            string description,
            string modelName,
            global::Mistral.Output3 output,
            string instructions,
            global::System.Collections.Generic.IList<string> tools,
            global::Mistral.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}