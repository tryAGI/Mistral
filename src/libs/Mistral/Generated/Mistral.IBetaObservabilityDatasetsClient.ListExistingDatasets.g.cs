#nullable enable

namespace Mistral
{
    public partial interface IBetaObservabilityDatasetsClient
    {
        /// <summary>
        /// List existing datasets
        /// </summary>
        /// <param name="pageSize">
        /// Default Value: 50
        /// </param>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="q"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mistral.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Mistral.DatasetPreviews> ListExistingDatasetsAsync(
            int? pageSize = default,
            int? page = default,
            string? q = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}