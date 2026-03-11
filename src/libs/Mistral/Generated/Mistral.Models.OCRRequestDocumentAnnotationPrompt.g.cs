
#nullable enable

namespace Mistral
{
    /// <summary>
    /// Optional prompt to guide the model in extracting structured output from the entire document. A document_annotation_format must be provided.
    /// </summary>
    public sealed partial class OCRRequestDocumentAnnotationPrompt
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}