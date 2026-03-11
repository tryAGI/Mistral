#nullable enable

namespace Mistral
{
    public partial interface IClassifiersClient
    {
        /// <summary>
        /// Classifications
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mistral.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Mistral.ClassificationResponse> ClassificationsAsync(

            global::Mistral.ClassificationRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Classifications
        /// </summary>
        /// <param name="model">
        /// ID of the model to use.
        /// </param>
        /// <param name="metadata"></param>
        /// <param name="input">
        /// Text to classify.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Mistral.ClassificationResponse> ClassificationsAsync(
            string model,
            global::Mistral.AnyOf<string, global::System.Collections.Generic.IList<string>> input,
            object? metadata = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}