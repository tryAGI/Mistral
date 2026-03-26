#nullable enable

namespace Mistral
{
    public partial interface IAudioVoicesClient
    {
        /// <summary>
        /// Update voice metadata<br/>
        /// Update voice metadata (name, gender, languages, age, tags).
        /// </summary>
        /// <param name="voiceId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mistral.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Mistral.VoiceResponse> UpdateVoiceMetadataAsync(
            global::System.Guid voiceId,

            global::Mistral.VoiceUpdateRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update voice metadata<br/>
        /// Update voice metadata (name, gender, languages, age, tags).
        /// </summary>
        /// <param name="voiceId"></param>
        /// <param name="name"></param>
        /// <param name="languages"></param>
        /// <param name="gender"></param>
        /// <param name="age"></param>
        /// <param name="tags"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Mistral.VoiceResponse> UpdateVoiceMetadataAsync(
            global::System.Guid voiceId,
            string? name = default,
            global::System.Collections.Generic.IList<string>? languages = default,
            string? gender = default,
            int? age = default,
            global::System.Collections.Generic.IList<string>? tags = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}