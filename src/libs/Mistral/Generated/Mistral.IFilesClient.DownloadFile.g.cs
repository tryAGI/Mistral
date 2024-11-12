#nullable enable

namespace Mistral
{
    public partial interface IFilesClient
    {
        /// <summary>
        /// Download File<br/>
        /// Download a file
        /// </summary>
        /// <param name="fileId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mistral.ApiException"></exception>
        global::System.Threading.Tasks.Task<byte[]> DownloadFileAsync(
            string fileId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}