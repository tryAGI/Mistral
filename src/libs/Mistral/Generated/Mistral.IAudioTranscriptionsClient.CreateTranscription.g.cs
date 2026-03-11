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
        /// <param name="model">
        /// ID of the model to be used.
        /// </param>
        /// <param name="file">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="filename">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="fileUrl">
        /// Url of a file to be transcribed<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="fileId">
        /// ID of a file uploaded to /v1/files<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="language">
        /// Language of the audio, e.g. 'en'. Providing the language can boost accuracy.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="temperature">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="stream">
        /// Default Value: false
        /// </param>
        /// <param name="diarize">
        /// Default Value: false
        /// </param>
        /// <param name="contextBias">
        /// Default Value: []
        /// </param>
        /// <param name="timestampGranularities">
        /// Granularities of timestamps to include in the response.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Mistral.TranscriptionResponse> CreateTranscriptionAsync(
            string model,
            byte[]? file = default,
            string? filename = default,
            string? fileUrl = default,
            string? fileId = default,
            string? language = default,
            double? temperature = default,
            bool? stream = default,
            bool? diarize = default,
            global::System.Collections.Generic.IList<string>? contextBias = default,
            global::System.Collections.Generic.IList<global::Mistral.TimestampGranularity>? timestampGranularities = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}