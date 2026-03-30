#nullable enable

namespace Mistral
{
    public partial interface IBetaObservabilityDatasetsClient
    {
        /// <summary>
        /// Export to the Files API and retrieve presigned URL to download the resulting JSONL file
        /// </summary>
        /// <param name="datasetId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mistral.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Mistral.DatasetExport> ExportToTheFilesApiAndRetrievePresignedUrlToDownloadTheResultingJsonlFileAsync(
            global::System.Guid datasetId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}