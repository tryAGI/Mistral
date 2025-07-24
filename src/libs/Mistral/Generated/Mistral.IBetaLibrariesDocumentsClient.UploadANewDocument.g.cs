#nullable enable

namespace Mistral
{
    public partial interface IBetaLibrariesDocumentsClient
    {
        /// <summary>
        /// Upload a new document.<br/>
        /// Given a library, upload a new document to that library. It is queued for processing, it status will change it has been processed. The processing has to be completed in order be discoverable for the library search
        /// </summary>
        /// <param name="libraryId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mistral.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Mistral.DocumentOut> UploadANewDocumentAsync(
            global::System.Guid libraryId,
            global::Mistral.LibrariesDocumentsUploadV1Request request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Upload a new document.<br/>
        /// Given a library, upload a new document to that library. It is queued for processing, it status will change it has been processed. The processing has to be completed in order be discoverable for the library search
        /// </summary>
        /// <param name="libraryId"></param>
        /// <param name="file">
        /// The File object (not file name) to be uploaded.<br/>
        ///  To upload a file and specify a custom file name you should format your request as such:<br/>
        ///  ```bash<br/>
        ///  file=@path/to/your/file.jsonl;filename=custom_name.jsonl<br/>
        ///  ```<br/>
        ///  Otherwise, you can just keep the original file name:<br/>
        ///  ```bash<br/>
        ///  file=@path/to/your/file.jsonl<br/>
        ///  ```
        /// </param>
        /// <param name="filename">
        /// The File object (not file name) to be uploaded.<br/>
        ///  To upload a file and specify a custom file name you should format your request as such:<br/>
        ///  ```bash<br/>
        ///  file=@path/to/your/file.jsonl;filename=custom_name.jsonl<br/>
        ///  ```<br/>
        ///  Otherwise, you can just keep the original file name:<br/>
        ///  ```bash<br/>
        ///  file=@path/to/your/file.jsonl<br/>
        ///  ```
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Mistral.DocumentOut> UploadANewDocumentAsync(
            global::System.Guid libraryId,
            byte[] file,
            string filename,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}