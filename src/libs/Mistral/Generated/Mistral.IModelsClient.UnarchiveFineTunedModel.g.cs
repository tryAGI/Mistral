#nullable enable

namespace Mistral
{
    public partial interface IModelsClient
    {
        /// <summary>
        /// Unarchive Fine Tuned Model<br/>
        /// Un-archive a fine-tuned model.
        /// </summary>
        /// <param name="modelId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Mistral.UnarchiveFTModelOut> UnarchiveFineTunedModelAsync(
            string modelId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}