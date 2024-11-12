#nullable enable

namespace Mistral
{
    public partial interface IModelsClient
    {
        /// <summary>
        /// List Models<br/>
        /// List all models available to the user.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mistral.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Mistral.ModelList> ListModelsAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}