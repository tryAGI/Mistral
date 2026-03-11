
#nullable enable

namespace Mistral
{
    /// <summary>
    /// Custom type for metadata with embedded validation.
    /// </summary>
    public sealed partial class MetadataDict
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}