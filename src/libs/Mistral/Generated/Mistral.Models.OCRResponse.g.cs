
#nullable enable

namespace Mistral
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OCRResponse
    {
        /// <summary>
        /// List of OCR info for pages.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pages")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public global::System.Collections.Generic.IList<global::Mistral.OCRPageObject> Pages { get; set; } = default!;

        /// <summary>
        /// The model used to generate the OCR.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public string Model { get; set; } = default!;

        /// <summary>
        /// Formatted response in the request_format if provided in json str
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("document_annotation")]
        public string? DocumentAnnotation { get; set; }

        /// <summary>
        /// Usage info for the OCR request.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("usage_info")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public global::Mistral.OCRUsageInfo UsageInfo { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OCRResponse" /> class.
        /// </summary>
        /// <param name="pages">
        /// List of OCR info for pages.
        /// </param>
        /// <param name="model">
        /// The model used to generate the OCR.
        /// </param>
        /// <param name="documentAnnotation">
        /// Formatted response in the request_format if provided in json str
        /// </param>
        /// <param name="usageInfo">
        /// Usage info for the OCR request.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OCRResponse(
            global::System.Collections.Generic.IList<global::Mistral.OCRPageObject> pages,
            string model,
            global::Mistral.OCRUsageInfo usageInfo,
            string? documentAnnotation)
        {
            this.Pages = pages ?? throw new global::System.ArgumentNullException(nameof(pages));
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.UsageInfo = usageInfo ?? throw new global::System.ArgumentNullException(nameof(usageInfo));
            this.DocumentAnnotation = documentAnnotation;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OCRResponse" /> class.
        /// </summary>
        public OCRResponse()
        {
        }
    }
}