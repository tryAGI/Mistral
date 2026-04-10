#nullable enable

namespace Mistral
{
    public partial interface IBatchClient
    {
        /// <summary>
        /// Get Batch Job<br/>
        /// Get a batch job details by its UUID.<br/>
        /// Args:<br/>
        ///     inline: If True, return results inline in the response.
        /// </summary>
        /// <param name="jobId"></param>
        /// <param name="inline"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mistral.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Mistral.BatchJobOut> GetBatchJobAsync(
            global::System.Guid jobId,
            bool? inline = default,
            global::Mistral.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}