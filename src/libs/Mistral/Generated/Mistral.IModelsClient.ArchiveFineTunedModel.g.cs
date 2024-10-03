#nullable enable

namespace Mistral
{
    public partial interface IModelsClient
    {
        /// <summary>
        /// Archive Fine Tuned Model<br/>
        /// Archive a fine-tuned model.
        /// </summary>
        /// <param name="modelId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Mistral.ArchiveFTModelOut> ArchiveFineTunedModelAsync(
            string modelId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}