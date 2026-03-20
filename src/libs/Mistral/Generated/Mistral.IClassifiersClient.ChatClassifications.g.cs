#nullable enable

namespace Mistral
{
    public partial interface IClassifiersClient
    {
        /// <summary>
        /// Chat Classifications
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mistral.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Mistral.ClassificationResponse> ChatClassificationsAsync(

            global::Mistral.ChatClassificationRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Chat Classifications
        /// </summary>
        /// <param name="model"></param>
        /// <param name="input">
        /// Chat to classify
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Mistral.ClassificationResponse> ChatClassificationsAsync(
            string model,
            global::Mistral.ChatClassificationRequestInputs input,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}