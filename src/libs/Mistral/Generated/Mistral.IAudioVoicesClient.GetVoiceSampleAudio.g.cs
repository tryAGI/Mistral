#nullable enable

namespace Mistral
{
    public partial interface IAudioVoicesClient
    {
        /// <summary>
        /// Get voice sample audio<br/>
        /// Get the audio sample for a voice
        /// </summary>
        /// <param name="voiceId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mistral.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> GetVoiceSampleAudioAsync(
            string voiceId,
            global::Mistral.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}