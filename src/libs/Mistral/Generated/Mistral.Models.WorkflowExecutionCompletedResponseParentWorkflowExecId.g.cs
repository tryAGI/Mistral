
#nullable enable

namespace Mistral
{
    /// <summary>
    /// Execution ID of the parent workflow that initiated this execution. If this is a root workflow, this field is not set.
    /// </summary>
    public sealed partial class WorkflowExecutionCompletedResponseParentWorkflowExecId
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}