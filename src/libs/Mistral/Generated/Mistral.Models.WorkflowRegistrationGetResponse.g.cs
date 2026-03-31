
#nullable enable

namespace Mistral
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WorkflowRegistrationGetResponse
    {
        /// <summary>
        /// The workflow registration
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workflow_registration")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Mistral.WorkflowRegistrationWithWorkerStatus WorkflowRegistration { get; set; }

        /// <summary>
        /// Deprecated: use workflow_registration<br/>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("workflow_version")]
        public global::Mistral.WorkflowRegistrationWithWorkerStatus WorkflowVersion { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowRegistrationGetResponse" /> class.
        /// </summary>
        /// <param name="workflowRegistration">
        /// The workflow registration
        /// </param>
        /// <param name="workflowVersion">
        /// Deprecated: use workflow_registration<br/>
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WorkflowRegistrationGetResponse(
            global::Mistral.WorkflowRegistrationWithWorkerStatus workflowRegistration,
            global::Mistral.WorkflowRegistrationWithWorkerStatus workflowVersion = default!)
        {
            this.WorkflowRegistration = workflowRegistration ?? throw new global::System.ArgumentNullException(nameof(workflowRegistration));
            this.WorkflowVersion = workflowVersion;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowRegistrationGetResponse" /> class.
        /// </summary>
        public WorkflowRegistrationGetResponse()
        {
        }
    }
}