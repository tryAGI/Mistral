#nullable enable

namespace Mistral
{
    public partial interface IBetaObservabilityJudgesClient
    {
        /// <summary>
        /// Get judge by id
        /// </summary>
        /// <param name="judgeId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mistral.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Mistral.JudgePreview> GetJudgeByIdAsync(
            global::System.Guid judgeId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}