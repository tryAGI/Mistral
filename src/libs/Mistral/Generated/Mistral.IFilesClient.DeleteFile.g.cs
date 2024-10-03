#nullable enable

namespace Mistral
{
    public partial interface IFilesClient
    {
        /// <summary>
        /// Delete File<br/>
        /// Delete a file.
        /// </summary>
        /// <param name="fileId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Mistral.DeleteFileOut> DeleteFileAsync(
            string fileId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}