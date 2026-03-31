
#nullable enable

namespace Mistral
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WorkflowArchiveResponse
    {
        /// <summary>
        /// The workflow spec
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workflow")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Mistral.Workflow Workflow { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowArchiveResponse" /> class.
        /// </summary>
        /// <param name="workflow">
        /// The workflow spec
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WorkflowArchiveResponse(
            global::Mistral.Workflow workflow)
        {
            this.Workflow = workflow ?? throw new global::System.ArgumentNullException(nameof(workflow));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowArchiveResponse" /> class.
        /// </summary>
        public WorkflowArchiveResponse()
        {
        }
    }
}