#nullable enable

namespace Mistral
{
    public partial interface IBetaObservabilityJudgesClient
    {
        /// <summary>
        /// Get judges with optional filtering and search
        /// </summary>
        /// <param name="typeFilter">
        /// Filter by judge output types
        /// </param>
        /// <param name="modelFilter">
        /// Filter by model names
        /// </param>
        /// <param name="pageSize">
        /// Default Value: 50
        /// </param>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="q"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mistral.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Mistral.JudgePreviews> GetJudgesWithOptionalFilteringAndSearchAsync(
            global::System.Collections.Generic.IList<global::Mistral.JudgeOutputType>? typeFilter = default,
            global::System.Collections.Generic.IList<string>? modelFilter = default,
            int? pageSize = default,
            int? page = default,
            string? q = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}