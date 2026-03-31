
#nullable enable

namespace Mistral
{
    /// <summary>
    /// Encoded input to the workflow, used when payload encoding is enabled.
    /// </summary>
    public sealed partial class WorkflowExecutionRequestEncodedInput
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}