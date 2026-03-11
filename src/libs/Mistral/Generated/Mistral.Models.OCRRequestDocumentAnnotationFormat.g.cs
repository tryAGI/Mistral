
#nullable enable

namespace Mistral
{
    /// <summary>
    /// Structured output class for extracting useful information from the entire document. Only json_schema is valid for this field
    /// </summary>
    public sealed partial class OCRRequestDocumentAnnotationFormat
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}