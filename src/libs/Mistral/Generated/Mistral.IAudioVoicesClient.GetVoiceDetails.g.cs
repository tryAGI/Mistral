#nullable enable

namespace Mistral
{
    public partial interface IAudioVoicesClient
    {
        /// <summary>
        /// Get voice details<br/>
        /// Get voice details (excluding sample)
        /// </summary>
        /// <param name="voiceId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mistral.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Mistral.VoiceResponse> GetVoiceDetailsAsync(
            string voiceId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}