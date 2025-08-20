#nullable enable

namespace Mistral
{
    public partial interface IAudioTranscriptionsClient
    {
        /// <summary>
        /// Create Transcription
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mistral.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Mistral.TranscriptionResponse> CreateTranscriptionAsync(
            global::Mistral.AudioTranscriptionRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create Transcription
        /// </summary>
        /// <param name="file"></param>
        /// <param name="fileId">
        /// ID of a file uploaded to /v1/files
        /// </param>
        /// <param name="fileUrl">
        /// Url of a file to be transcribed
        /// </param>
        /// <param name="language">
        /// Language of the audio, e.g. 'en'. Providing the language can boost accuracy.
        /// </param>
        /// <param name="model"></param>
        /// <param name="stream">
        /// Default Value: false
        /// </param>
        /// <param name="temperature"></param>
        /// <param name="timestampGranularities">
        /// Granularities of timestamps to include in the response.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Mistral.TranscriptionResponse> CreateTranscriptionAsync(
            string model,
            object? file = default,
            string? fileId = default,
            string? fileUrl = default,
            string? language = default,
            bool? stream = default,
            double? temperature = default,
            global::System.Collections.Generic.IList<global::Mistral.TimestampGranularity>? timestampGranularities = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}