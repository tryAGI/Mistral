
#nullable enable

namespace Mistral
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OCRPageObject
    {
        /// <summary>
        /// The page index in a pdf document starting from 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Index { get; set; }

        /// <summary>
        /// The markdown string response of the page
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("markdown")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Markdown { get; set; }

        /// <summary>
        /// List of all extracted images in the page
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("images")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Mistral.OCRImageObject> Images { get; set; }

        /// <summary>
        /// List of all extracted tables in the page
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tables")]
        public global::System.Collections.Generic.IList<global::Mistral.OCRTableObject>? Tables { get; set; }

        /// <summary>
        /// List of all hyperlinks in the page
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hyperlinks")]
        public global::System.Collections.Generic.IList<string>? Hyperlinks { get; set; }

        /// <summary>
        /// Header of the page
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("header")]
        public string? Header { get; set; }

        /// <summary>
        /// Footer of the page
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("footer")]
        public string? Footer { get; set; }

        /// <summary>
        /// The dimensions of the PDF Page's screenshot image
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dimensions")]
        public global::Mistral.OCRPageDimensions? Dimensions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OCRPageObject" /> class.
        /// </summary>
        /// <param name="index">
        /// The page index in a pdf document starting from 0
        /// </param>
        /// <param name="markdown">
        /// The markdown string response of the page
        /// </param>
        /// <param name="images">
        /// List of all extracted images in the page
        /// </param>
        /// <param name="tables">
        /// List of all extracted tables in the page
        /// </param>
        /// <param name="hyperlinks">
        /// List of all hyperlinks in the page
        /// </param>
        /// <param name="header">
        /// Header of the page
        /// </param>
        /// <param name="footer">
        /// Footer of the page
        /// </param>
        /// <param name="dimensions">
        /// The dimensions of the PDF Page's screenshot image
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OCRPageObject(
            int index,
            string markdown,
            global::System.Collections.Generic.IList<global::Mistral.OCRImageObject> images,
            global::System.Collections.Generic.IList<global::Mistral.OCRTableObject>? tables,
            global::System.Collections.Generic.IList<string>? hyperlinks,
            string? header,
            string? footer,
            global::Mistral.OCRPageDimensions? dimensions)
        {
            this.Index = index;
            this.Markdown = markdown ?? throw new global::System.ArgumentNullException(nameof(markdown));
            this.Images = images ?? throw new global::System.ArgumentNullException(nameof(images));
            this.Tables = tables;
            this.Hyperlinks = hyperlinks;
            this.Header = header;
            this.Footer = footer;
            this.Dimensions = dimensions;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OCRPageObject" /> class.
        /// </summary>
        public OCRPageObject()
        {
        }
    }
}