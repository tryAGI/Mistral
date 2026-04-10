#nullable enable

namespace Mistral
{
    public partial interface IAudioSpeechClient
    {
        /// <summary>
        /// Speech<br/>
        /// Generate speech from text using a saved voice or a reference audio clip.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mistral.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Mistral.SpeechResponse> SpeechAsync(

            global::Mistral.SpeechRequest request,
            global::Mistral.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Speech<br/>
        /// Generate speech from text using a saved voice or a reference audio clip.
        /// </summary>
        /// <param name="model"></param>
        /// <param name="voiceId">
        /// The preset or custom voice to use for generating the speech.
        /// </param>
        /// <param name="refAudio">
        /// The base64-encoded audio reference for zero-shot voice cloning.
        /// </param>
        /// <param name="input">
        /// Text to generate speech from.
        /// </param>
        /// <param name="responseFormat">
        /// Output audio format. Defaults to mp3.<br/>
        /// Default Value: mp3
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Mistral.SpeechResponse> SpeechAsync(
            string input,
            string? model = default,
            string? voiceId = default,
            string? refAudio = default,
            global::Mistral.SpeechOutputFormat? responseFormat = default,
            global::Mistral.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}