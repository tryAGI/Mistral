#nullable enable

namespace Mistral
{
    public partial interface IBetaObservabilityChatCompletionEventsFieldsClient
    {
        /// <summary>
        /// Get Chat Completion Fields
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mistral.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Mistral.ChatCompletionFields> GetChatCompletionFieldsAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}