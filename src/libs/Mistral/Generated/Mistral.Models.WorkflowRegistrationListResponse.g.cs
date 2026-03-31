
#nullable enable

namespace Mistral
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WorkflowRegistrationListResponse
    {
        /// <summary>
        /// A list of workflow registrations
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workflow_registrations")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Mistral.WorkflowRegistration> WorkflowRegistrations { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("next_cursor")]
        public global::System.Guid? NextCursor { get; set; }

        /// <summary>
        /// Deprecated: use workflow_registrations<br/>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("workflow_versions")]
        public global::System.Collections.Generic.IList<global::Mistral.WorkflowRegistration> WorkflowVersions { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowRegistrationListResponse" /> class.
        /// </summary>
        /// <param name="workflowRegistrations">
        /// A list of workflow registrations
        /// </param>
        /// <param name="nextCursor"></param>
        /// <param name="workflowVersions">
        /// Deprecated: use workflow_registrations<br/>
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WorkflowRegistrationListResponse(
            global::System.Collections.Generic.IList<global::Mistral.WorkflowRegistration> workflowRegistrations,
            global::System.Guid? nextCursor,
            global::System.Collections.Generic.IList<global::Mistral.WorkflowRegistration> workflowVersions = default!)
        {
            this.WorkflowRegistrations = workflowRegistrations ?? throw new global::System.ArgumentNullException(nameof(workflowRegistrations));
            this.NextCursor = nextCursor;
            this.WorkflowVersions = workflowVersions;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowRegistrationListResponse" /> class.
        /// </summary>
        public WorkflowRegistrationListResponse()
        {
        }
    }
}