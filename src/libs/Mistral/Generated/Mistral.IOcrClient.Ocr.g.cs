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
        global::System.Threading.Tasks.Task<global::Mistral.OCRResponse> OcrAsync(

            global::Mistral.OCRRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// OCR
        /// </summary>
        /// <param name="model"></param>
        /// <param name="id"></param>
        /// <param name="document">
        /// Document to run OCR on
        /// </param>
        /// <param name="pages">
        /// Specific pages user wants to process in various formats: single number, range, or list of both. Starts from 0
        /// </param>
        /// <param name="includeImageBase64">
        /// Include image URLs in response
        /// </param>
        /// <param name="imageLimit">
        /// Max images to extract
        /// </param>
        /// <param name="imageMinSize">
        /// Minimum height and width of image to extract
        /// </param>
        /// <param name="bboxAnnotationFormat">
        /// Structured output class for extracting useful information from each extracted bounding box / image from document. Only json_schema is valid for this field
        /// </param>
        /// <param name="documentAnnotationFormat">
        /// Structured output class for extracting useful information from the entire document. Only json_schema is valid for this field
        /// </param>
        /// <param name="documentAnnotationPrompt">
        /// Optional prompt to guide the model in extracting structured output from the entire document. A document_annotation_format must be provided.
        /// </param>
        /// <param name="confidenceScoresGranularity">
        /// Granularity level for confidence scores. Set to `"page"` to get aggregate statistics (average and minimum) per page, or `"word"` to also get per-word scores on each page and table. Defaults to `null` (no confidence scores returned).
        /// </param>
        /// <param name="tableFormat"></param>
        /// <param name="extractHeader">
        /// Default Value: false
        /// </param>
        /// <param name="extractFooter">
        /// Default Value: false
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Mistral.OCRResponse> OcrAsync(
            global::Mistral.AnyOf<global::Mistral.FileChunk, global::Mistral.DocumentURLChunk, global::Mistral.ImageURLChunk> document,
            string? model = default,
            string? id = default,
            global::System.Collections.Generic.IList<int>? pages = default,
            bool? includeImageBase64 = default,
            int? imageLimit = default,
            int? imageMinSize = default,
            global::Mistral.ResponseFormat? bboxAnnotationFormat = default,
            global::Mistral.ResponseFormat? documentAnnotationFormat = default,
            string? documentAnnotationPrompt = default,
            global::Mistral.OCRRequestConfidenceScoresGranularity2? confidenceScoresGranularity = default,
            global::Mistral.OCRRequestTableFormat2? tableFormat = default,
            bool? extractHeader = default,
            bool? extractFooter = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}