#nullable enable

namespace Mistral
{
    public partial interface IDeprecatedFineTuningClient
    {
        /// <summary>
        /// Start Fine Tuning Job<br/>
        /// Request the start of a validated fine tuning job.
        /// </summary>
        /// <param name="jobId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mistral.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Mistral.JobsApiRoutesFineTuningStartFineTuningJobResponse> StartFineTuningJobAsync(
            global::System.Guid jobId,
            global::Mistral.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}