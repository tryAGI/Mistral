
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Mistral
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OCRRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string? Model { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Document to run OCR on
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("document")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Mistral.JsonConverters.AnyOfJsonConverter<global::Mistral.FileChunk, global::Mistral.DocumentURLChunk, global::Mistral.ImageURLChunk>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Mistral.AnyOf<global::Mistral.FileChunk, global::Mistral.DocumentURLChunk, global::Mistral.ImageURLChunk> Document { get; set; }

        /// <summary>
        /// Specific pages user wants to process in various formats: single number, range, or list of both. Starts from 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pages")]
        public global::System.Collections.Generic.IList<int>? Pages { get; set; }

        /// <summary>
        /// Include image URLs in response
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("include_image_base64")]
        public bool? IncludeImageBase64 { get; set; }

        /// <summary>
        /// Max images to extract
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_limit")]
        public int? ImageLimit { get; set; }

        /// <summary>
        /// Minimum height and width of image to extract
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_min_size")]
        public int? ImageMinSize { get; set; }

        /// <summary>
        /// Structured output class for extracting useful information from each extracted bounding box / image from document. Only json_schema is valid for this field
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bbox_annotation_format")]
        public global::Mistral.ResponseFormat? BboxAnnotationFormat { get; set; }

        /// <summary>
        /// Structured output class for extracting useful information from the entire document. Only json_schema is valid for this field
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("document_annotation_format")]
        public global::Mistral.ResponseFormat? DocumentAnnotationFormat { get; set; }

        /// <summary>
        /// Optional prompt to guide the model in extracting structured output from the entire document. A document_annotation_format must be provided.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("document_annotation_prompt")]
        public string? DocumentAnnotationPrompt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("table_format")]
        public global::Mistral.OCRRequestTableFormat2? TableFormat { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("extract_header")]
        public bool? ExtractHeader { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("extract_footer")]
        public bool? ExtractFooter { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OCRRequest" /> class.
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
        /// <param name="tableFormat"></param>
        /// <param name="extractHeader">
        /// Default Value: false
        /// </param>
        /// <param name="extractFooter">
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OCRRequest(
            global::Mistral.AnyOf<global::Mistral.FileChunk, global::Mistral.DocumentURLChunk, global::Mistral.ImageURLChunk> document,
            string? model,
            string? id,
            global::System.Collections.Generic.IList<int>? pages,
            bool? includeImageBase64,
            int? imageLimit,
            int? imageMinSize,
            global::Mistral.ResponseFormat? bboxAnnotationFormat,
            global::Mistral.ResponseFormat? documentAnnotationFormat,
            string? documentAnnotationPrompt,
            global::Mistral.OCRRequestTableFormat2? tableFormat,
            bool? extractHeader,
            bool? extractFooter)
        {
            this.Document = document;
            this.Model = model;
            this.Id = id;
            this.Pages = pages;
            this.IncludeImageBase64 = includeImageBase64;
            this.ImageLimit = imageLimit;
            this.ImageMinSize = imageMinSize;
            this.BboxAnnotationFormat = bboxAnnotationFormat;
            this.DocumentAnnotationFormat = documentAnnotationFormat;
            this.DocumentAnnotationPrompt = documentAnnotationPrompt;
            this.TableFormat = tableFormat;
            this.ExtractHeader = extractHeader;
            this.ExtractFooter = extractFooter;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OCRRequest" /> class.
        /// </summary>
        public OCRRequest()
        {
        }
    }
}