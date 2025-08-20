#nullable enable

namespace Mistral
{
    public partial interface IBatchClient
    {
        /// <summary>
        /// Create Batch Job<br/>
        /// Create a new batch job, it will be queued for processing.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mistral.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Mistral.BatchJobOut> CreateBatchJobAsync(
            global::Mistral.BatchJobIn request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create Batch Job<br/>
        /// Create a new batch job, it will be queued for processing.
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="endpoint"></param>
        /// <param name="inputFiles"></param>
        /// <param name="metadata"></param>
        /// <param name="model"></param>
        /// <param name="timeoutHours">
        /// Default Value: 24
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Mistral.BatchJobOut> CreateBatchJobAsync(
            global::Mistral.ApiEndpoint endpoint,
            global::System.Collections.Generic.IList<global::System.Guid> inputFiles,
            string? agentId = default,
            global::System.Collections.Generic.Dictionary<string, string>? metadata = default,
            string? model = default,
            int? timeoutHours = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}