
#nullable enable

namespace Mistral
{
    /// <summary>
    /// Paragraph-level bounding boxes for all content blocks in reading order (populated when include_blocks is True)
    /// </summary>
    public sealed partial class OCRPageObjectBlocks
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}