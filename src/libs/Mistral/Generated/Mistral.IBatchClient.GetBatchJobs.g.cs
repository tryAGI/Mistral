#nullable enable

namespace Mistral
{
    public partial interface IBatchClient
    {
        /// <summary>
        /// Get Batch Jobs<br/>
        /// Get a list of batch jobs for your organization and user.
        /// </summary>
        /// <param name="page">
        /// Default Value: 0
        /// </param>
        /// <param name="pageSize">
        /// Default Value: 100
        /// </param>
        /// <param name="model"></param>
        /// <param name="agentId"></param>
        /// <param name="metadata"></param>
        /// <param name="createdAfter"></param>
        /// <param name="createdByMe">
        /// Default Value: false
        /// </param>
        /// <param name="status"></param>
        /// <param name="orderBy">
        /// Default Value: -created
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mistral.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Mistral.BatchJobsOut> GetBatchJobsAsync(
            int? page = default,
            int? pageSize = default,
            string? model = default,
            string? agentId = default,
            object? metadata = default,
            global::System.DateTime? createdAfter = default,
            bool? createdByMe = default,
            global::System.Collections.Generic.IList<global::Mistral.BatchJobStatus>? status = default,
            global::Mistral.JobsApiRoutesBatchGetBatchJobsOrderBy? orderBy = default,
            global::Mistral.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get Batch Jobs<br/>
        /// Get a list of batch jobs for your organization and user.
        /// </summary>
        /// <param name="page">
        /// Default Value: 0
        /// </param>
        /// <param name="pageSize">
        /// Default Value: 100
        /// </param>
        /// <param name="model"></param>
        /// <param name="agentId"></param>
        /// <param name="metadata"></param>
        /// <param name="createdAfter"></param>
        /// <param name="createdByMe">
        /// Default Value: false
        /// </param>
        /// <param name="status"></param>
        /// <param name="orderBy">
        /// Default Value: -created
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mistral.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Mistral.AutoSDKHttpResponse<global::Mistral.BatchJobsOut>> GetBatchJobsAsResponseAsync(
            int? page = default,
            int? pageSize = default,
            string? model = default,
            string? agentId = default,
            object? metadata = default,
            global::System.DateTime? createdAfter = default,
            bool? createdByMe = default,
            global::System.Collections.Generic.IList<global::Mistral.BatchJobStatus>? status = default,
            global::Mistral.JobsApiRoutesBatchGetBatchJobsOrderBy? orderBy = default,
            global::Mistral.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Wraps GetBatchJobsAsync as an IAsyncEnumerable<global::Mistral.BatchJobOut> that auto-pages over the response.
        /// </summary>
        /// <param name="pageSize">
        /// Default Value: 100
        /// </param>
        /// <param name="model"></param>
        /// <param name="agentId"></param>
        /// <param name="metadata"></param>
        /// <param name="createdAfter"></param>
        /// <param name="createdByMe">
        /// Default Value: false
        /// </param>
        /// <param name="status"></param>
        /// <param name="orderBy">
        /// Default Value: -created
        /// </param> 
        /// <param name="page">Initial page number to start enumerating from. Defaults to 1.</param>
        /// <param name="cancellationToken"></param>
        global::System.Collections.Generic.IAsyncEnumerable<global::Mistral.BatchJobOut> GetBatchJobsAutoPagingAsync(
              int? pageSize = default,
            string? model = default,
            string? agentId = default,
            object? metadata = default,
            global::System.DateTime? createdAfter = default,
            bool? createdByMe = default,
            global::System.Collections.Generic.IList<global::Mistral.BatchJobStatus>? status = default,
            global::Mistral.JobsApiRoutesBatchGetBatchJobsOrderBy? orderBy = default,
            int? page = null,
            global::System.Threading.CancellationToken cancellationToken = default);

    }
}