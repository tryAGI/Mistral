#nullable enable

namespace Mistral
{
    public partial interface IFineTuningClient
    {
        /// <summary>
        /// Start Fine Tuning Job<br/>
        /// Request the start of a validated fine tuning job.
        /// </summary>
        /// <param name="jobId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Mistral.DetailedJobOut> StartFineTuningJobAsync(
            global::System.Guid jobId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}