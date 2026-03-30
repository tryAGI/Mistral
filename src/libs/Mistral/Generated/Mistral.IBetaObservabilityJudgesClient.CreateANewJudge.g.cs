#nullable enable

namespace Mistral
{
    public partial interface IBetaObservabilityJudgesClient
    {
        /// <summary>
        /// Create a new judge
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mistral.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Mistral.JudgePreview> CreateANewJudgeAsync(

            global::Mistral.PostJudgeInSchema request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a new judge
        /// </summary>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="modelName"></param>
        /// <param name="output"></param>
        /// <param name="instructions"></param>
        /// <param name="tools"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Mistral.JudgePreview> CreateANewJudgeAsync(
            string name,
            string description,
            string modelName,
            global::Mistral.Output2 output,
            string instructions,
            global::System.Collections.Generic.IList<string> tools,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}