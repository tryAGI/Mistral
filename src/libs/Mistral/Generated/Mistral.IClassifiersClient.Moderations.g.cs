#nullable enable

namespace Mistral
{
    public partial interface IClassifiersClient
    {
        /// <summary>
        /// Moderations
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mistral.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Mistral.ModerationResponse> ModerationsAsync(
            global::Mistral.ClassificationRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Moderations
        /// </summary>
        /// <param name="input">
        /// Text to classify.
        /// </param>
        /// <param name="model">
        /// ID of the model to use.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Mistral.ModerationResponse> ModerationsAsync(
            global::Mistral.AnyOf<string, global::System.Collections.Generic.IList<string>> input,
            string model,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}