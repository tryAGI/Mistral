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
        /// <param name="inputFiles">
        /// The list of input files to be used for batch inference, these files should be `jsonl` files, containing the input data corresponding to the bory request for the batch inference in a "body" field. An example of such file is the following: ```json {"custom_id": "0", "body": {"max_tokens": 100, "messages": [{"role": "user", "content": "What is the best French cheese?"}]}} {"custom_id": "1", "body": {"max_tokens": 100, "messages": [{"role": "user", "content": "What is the best French wine?"}]}} ```
        /// </param>
        /// <param name="requests"></param>
        /// <param name="endpoint">
        /// The endpoint to be used for batch inference.
        /// </param>
        /// <param name="model">
        /// The model to be used for batch inference.
        /// </param>
        /// <param name="agentId">
        /// In case you want to use a specific agent from the **deprecated** agents api for batch inference, you can specify the agent ID here.
        /// </param>
        /// <param name="metadata">
        /// The metadata of your choice to be associated with the batch inference job.
        /// </param>
        /// <param name="timeoutHours">
        /// The timeout in hours for the batch inference job.<br/>
        /// Default Value: 24
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Mistral.BatchJobOut> CreateBatchJobAsync(
            global::Mistral.ApiEndpoint endpoint,
            global::System.Collections.Generic.IList<global::System.Guid>? inputFiles = default,
            global::System.Collections.Generic.IList<global::Mistral.BatchRequest>? requests = default,
            string? model = default,
            string? agentId = default,
            global::System.Collections.Generic.Dictionary<string, string>? metadata = default,
            int? timeoutHours = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}