
#nullable enable

namespace Mistral
{
    /// <summary>
    /// Granularity for confidence scores: 'word' (per-word scores) or 'page' (aggregate only). Defaults to None (no confidence scores) to keep response payload small.
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