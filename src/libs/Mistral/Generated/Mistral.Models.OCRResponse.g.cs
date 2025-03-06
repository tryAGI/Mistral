
#nullable enable

namespace Mistral
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OCRResponse
    {
        /// <summary>
        /// The model used to generate the OCR.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; }

        /// <summary>
        /// List of OCR info for pages.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pages")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Mistral.OCRPageObject> Pages { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("usage_info")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Mistral.OCRUsageInfo UsageInfo { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OCRResponse" /> class.
        /// </summary>
        /// <param name="model">
        /// The model used to generate the OCR.
        /// </param>
        /// <param name="pages">
        /// List of OCR info for pages.
        /// </param>
        /// <param name="usageInfo"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OCRResponse(
            string model,
            global::System.Collections.Generic.IList<global::Mistral.OCRPageObject> pages,
            global::Mistral.OCRUsageInfo usageInfo)
        {
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.Pages = pages ?? throw new global::System.ArgumentNullException(nameof(pages));
            this.UsageInfo = usageInfo ?? throw new global::System.ArgumentNullException(nameof(usageInfo));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OCRResponse" /> class.
        /// </summary>
        public OCRResponse()
        {
        }
    }
}