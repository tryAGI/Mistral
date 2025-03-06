#nullable enable

namespace Mistral
{
    public partial interface IOcrClient
    {
        /// <summary>
        /// OCR
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mistral.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Mistral.OCRResponse> OCRAsync(
            global::Mistral.OCRRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// OCR
        /// </summary>
        /// <param name="document">
        /// Document to run OCR on
        /// </param>
        /// <param name="id"></param>
        /// <param name="imageLimit">
        /// Max images to extract
        /// </param>
        /// <param name="imageMinSize">
        /// Minimum height and width of image to extract
        /// </param>
        /// <param name="includeImageBase64">
        /// Include image URLs in response
        /// </param>
        /// <param name="model"></param>
        /// <param name="pages">
        /// Specific pages user wants to process in various formats: single number, range, or list of both. Starts from 0
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Mistral.OCRResponse> OCRAsync(
            global::Mistral.AnyOf<global::Mistral.DocumentURLChunk, global::Mistral.ImageURLChunk> document,
            string? model,
            string? id = default,
            int? imageLimit = default,
            int? imageMinSize = default,
            bool? includeImageBase64 = default,
            global::System.Collections.Generic.IList<int>? pages = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}