#nullable enable

namespace Mistral
{
    public partial interface IAudioVoicesClient
    {
        /// <summary>
        /// Create a new voice<br/>
        /// Create a new voice with a base64-encoded audio sample
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mistral.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Mistral.VoiceResponse> CreateANewVoiceAsync(

            global::Mistral.VoiceCreateRequest request,
            global::Mistral.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a new voice<br/>
        /// Create a new voice with a base64-encoded audio sample
        /// </summary>
        /// <param name="name"></param>
        /// <param name="slug"></param>
        /// <param name="languages">
        /// Default Value: []
        /// </param>
        /// <param name="gender"></param>
        /// <param name="age"></param>
        /// <param name="tags"></param>
        /// <param name="color"></param>
        /// <param name="retentionNotice">
        /// Default Value: 30
        /// </param>
        /// <param name="sampleAudio">
        /// Base64-encoded audio file
        /// </param>
        /// <param name="sampleFilename">
        /// Original filename for extension detection
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Mistral.VoiceResponse> CreateANewVoiceAsync(
            string name,
            string sampleAudio,
            string? slug = default,
            global::System.Collections.Generic.IList<string>? languages = default,
            string? gender = default,
            int? age = default,
            global::System.Collections.Generic.IList<string>? tags = default,
            string? color = default,
            int? retentionNotice = default,
            string? sampleFilename = default,
            global::Mistral.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}