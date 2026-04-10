#nullable enable

namespace Mistral
{
    public partial interface IEmbeddingsClient
    {
        /// <summary>
        /// Embeddings<br/>
        /// Embeddings
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mistral.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Mistral.EmbeddingResponse> EmbeddingsAsync(

            global::Mistral.EmbeddingRequest request,
            global::Mistral.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Embeddings<br/>
        /// Embeddings
        /// </summary>
        /// <param name="model">
        /// ID of the model to use.<br/>
        /// Example: mistral-embed
        /// </param>
        /// <param name="metadata"></param>
        /// <param name="input">
        /// Text to embed.<br/>
        /// Example: [Embed this sentence., As well as this one.]
        /// </param>
        /// <param name="outputDimension">
        /// The dimension of the output embeddings when feature available. If not provided, a default output dimension will be used.
        /// </param>
        /// <param name="outputDtype">
        /// The data type of the output embeddings when feature available. If not provided, a default output data type will be used.<br/>
        /// Default Value: float
        /// </param>
        /// <param name="encodingFormat">
        /// The format of embeddings in the response.<br/>
        /// Default Value: float
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Mistral.EmbeddingResponse> EmbeddingsAsync(
            string model,
            global::Mistral.AnyOf<string, global::System.Collections.Generic.IList<string>> input,
            object? metadata = default,
            int? outputDimension = default,
            global::Mistral.EmbeddingDtype? outputDtype = default,
            global::Mistral.EncodingFormat? encodingFormat = default,
            global::Mistral.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}