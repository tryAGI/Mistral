
#nullable enable

namespace Mistral
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OCRTableObject
    {
        /// <summary>
        /// Table ID for extracted table in a page
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Content of the table in the given format
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Content { get; set; }

        /// <summary>
        /// Format of the table
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Mistral.JsonConverters.OCRTableObjectFormatJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Mistral.OCRTableObjectFormat Format { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OCRTableObject" /> class.
        /// </summary>
        /// <param name="id">
        /// Table ID for extracted table in a page
        /// </param>
        /// <param name="content">
        /// Content of the table in the given format
        /// </param>
        /// <param name="format">
        /// Format of the table
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OCRTableObject(
            string id,
            string content,
            global::Mistral.OCRTableObjectFormat format)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Content = content ?? throw new global::System.ArgumentNullException(nameof(content));
            this.Format = format;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OCRTableObject" /> class.
        /// </summary>
        public OCRTableObject()
        {
        }
    }
}