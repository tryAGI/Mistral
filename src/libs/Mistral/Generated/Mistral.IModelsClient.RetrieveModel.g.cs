#nullable enable

namespace Mistral
{
    public partial interface IModelsClient
    {
        /// <summary>
        /// Retrieve Model<br/>
        /// Retrieve a model information.
        /// </summary>
        /// <param name="modelId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Mistral.OneOf<global::Mistral.BaseModelCard, global::Mistral.FTModelCard>> RetrieveModelAsync(
            string modelId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}