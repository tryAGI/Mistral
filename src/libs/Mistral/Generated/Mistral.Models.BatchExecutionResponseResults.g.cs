
#nullable enable

namespace Mistral
{
    /// <summary>
    /// Mapping of execution_id to result with status and optional error message
    /// </summary>
    public sealed partial class BatchExecutionResponseResults
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}