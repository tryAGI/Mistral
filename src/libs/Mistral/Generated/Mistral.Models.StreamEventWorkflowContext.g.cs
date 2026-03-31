
#nullable enable

namespace Mistral
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class StreamEventWorkflowContext
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("namespace")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Namespace { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workflow_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string WorkflowName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workflow_exec_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string WorkflowExecId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parent_workflow_exec_id")]
        public string? ParentWorkflowExecId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("root_workflow_exec_id")]
        public string? RootWorkflowExecId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StreamEventWorkflowContext" /> class.
        /// </summary>
        /// <param name="namespace"></param>
        /// <param name="workflowName"></param>
        /// <param name="workflowExecId"></param>
        /// <param name="parentWorkflowExecId"></param>
        /// <param name="rootWorkflowExecId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public StreamEventWorkflowContext(
            string @namespace,
            string workflowName,
            string workflowExecId,
            string? parentWorkflowExecId,
            string? rootWorkflowExecId)
        {
            this.Namespace = @namespace ?? throw new global::System.ArgumentNullException(nameof(@namespace));
            this.WorkflowName = workflowName ?? throw new global::System.ArgumentNullException(nameof(workflowName));
            this.WorkflowExecId = workflowExecId ?? throw new global::System.ArgumentNullException(nameof(workflowExecId));
            this.ParentWorkflowExecId = parentWorkflowExecId;
            this.RootWorkflowExecId = rootWorkflowExecId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StreamEventWorkflowContext" /> class.
        /// </summary>
        public StreamEventWorkflowContext()
        {
        }
    }
}