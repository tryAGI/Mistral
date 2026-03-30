#nullable enable

namespace Mistral
{
    public partial interface IBetaObservabilityChatCompletionEventsClient
    {
        /// <summary>
        /// Get Chat Completion Event
        /// </summary>
        /// <param name="eventId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mistral.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Mistral.ChatCompletionEvent> GetChatCompletionEventAsync(
            global::System.Guid eventId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}