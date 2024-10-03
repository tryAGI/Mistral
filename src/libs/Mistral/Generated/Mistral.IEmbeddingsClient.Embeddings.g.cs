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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Mistral.EmbeddingResponse> EmbeddingsAsync(
            global::Mistral.EmbeddingRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Embeddings<br/>
        /// Embeddings
        /// </summary>
        /// <param name="encodingFormat">
        /// The format to return the embeddings in.<br/>
        /// Default Value: float
        /// </param>
        /// <param name="input">
        /// Text to embed.
        /// </param>
        /// <param name="model">
        /// ID of the model to use.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Mistral.EmbeddingResponse> EmbeddingsAsync(
            global::Mistral.AnyOf<string, global::System.Collections.Generic.IList<string>> input,
            string model,
            string? encodingFormat = "float",
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}