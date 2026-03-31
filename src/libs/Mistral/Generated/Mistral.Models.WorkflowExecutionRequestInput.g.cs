
#nullable enable

namespace Mistral
{
    /// <summary>
    /// The input to the workflow. This should be a dictionary that matches the workflow's input schema.
    /// </summary>
    public sealed partial class WorkflowExecutionRequestInput
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}