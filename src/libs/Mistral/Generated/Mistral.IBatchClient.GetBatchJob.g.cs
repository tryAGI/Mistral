#nullable enable

namespace Mistral
{
    public partial interface IBatchClient
    {
        /// <summary>
        /// Get Batch Job<br/>
        /// Get a batch job details by its UUID.
        /// </summary>
        /// <param name="jobId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Mistral.BatchJobOut> GetBatchJobAsync(
            global::System.Guid jobId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}