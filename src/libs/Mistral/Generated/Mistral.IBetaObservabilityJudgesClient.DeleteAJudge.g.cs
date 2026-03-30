#nullable enable

namespace Mistral
{
    public partial interface IBetaObservabilityJudgesClient
    {
        /// <summary>
        /// Delete a judge
        /// </summary>
        /// <param name="judgeId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mistral.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteAJudgeAsync(
            global::System.Guid judgeId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}