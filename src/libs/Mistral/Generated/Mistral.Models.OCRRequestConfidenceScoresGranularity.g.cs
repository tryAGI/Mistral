
#nullable enable

namespace Mistral
{
    /// <summary>
    /// Granularity level for confidence scores. Set to `"page"` to get aggregate statistics (average and minimum) per page, or `"word"` to also get per-word scores on each page and table. Defaults to `null` (no confidence scores returned).
    /// </summary>
    public sealed partial class OCRRequestConfidenceScoresGranularity
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}