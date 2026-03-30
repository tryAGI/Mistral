#nullable enable

namespace Mistral
{
    public partial interface IBetaObservabilityChatCompletionEventsClient
    {
        /// <summary>
        /// Get Similar Chat Completion Events
        /// </summary>
        /// <param name="eventId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mistral.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Mistral.ChatCompletionEvents> GetSimilarChatCompletionEventsAsync(
            global::System.Guid eventId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}