#nullable enable

namespace Mistral
{
    public partial interface IAudioVoicesClient
    {
        /// <summary>
        /// Delete a custom voice<br/>
        /// Delete a custom voice
        /// </summary>
        /// <param name="voiceId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mistral.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Mistral.VoiceResponse> DeleteACustomVoiceAsync(
            global::System.Guid voiceId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}