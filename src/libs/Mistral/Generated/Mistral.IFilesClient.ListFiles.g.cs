#nullable enable

namespace Mistral
{
    public partial interface IFilesClient
    {
        /// <summary>
        /// List Files<br/>
        /// Returns a list of files that belong to the user's organization.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Mistral.ListFilesOut> ListFilesAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}