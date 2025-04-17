#nullable enable

namespace Mistral
{
    public partial interface IFineTuningClient
    {
        /// <summary>
        /// Get Fine Tuning Job<br/>
        /// Get a fine-tuned job details by its UUID.
        /// </summary>
        /// <param name="jobId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mistral.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Mistral.JobsApiRoutesFineTuningGetFineTuningJobResponse> GetFineTuningJobAsync(
            global::System.Guid jobId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}