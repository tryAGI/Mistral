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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mistral.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> GetVoiceSampleAudioAsync(
            string voiceId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}