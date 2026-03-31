
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Mistral
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WorkflowScheduleRequest
    {
        /// <summary>
        /// The schedule definition
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("schedule")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Mistral.ScheduleDefinition Schedule { get; set; }

        /// <summary>
        /// The ID of the workflow registration to schedule
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workflow_registration_id")]
        public global::System.Guid? WorkflowRegistrationId { get; set; }

        /// <summary>
        /// Deprecated: use workflow_registration_id
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workflow_version_id")]
        public global::System.Guid? WorkflowVersionId { get; set; }

        /// <summary>
        /// The name or ID of the workflow to schedule
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workflow_identifier")]
        public string? WorkflowIdentifier { get; set; }

        /// <summary>
        /// Deprecated. Use deployment_name instead.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workflow_task_queue")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public string? WorkflowTaskQueue { get; set; }

        /// <summary>
        /// Allows you to specify a custom schedule ID. If not provided, a random ID will be generated.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("schedule_id")]
        public string? ScheduleId { get; set; }

        /// <summary>
        /// Name of the deployment to route this schedule to
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deployment_name")]
        public string? DeploymentName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowScheduleRequest" /> class.
        /// </summary>
        /// <param name="schedule">
        /// The schedule definition
        /// </param>
        /// <param name="workflowRegistrationId">
        /// The ID of the workflow registration to schedule
        /// </param>
        /// <param name="workflowVersionId">
        /// Deprecated: use workflow_registration_id
        /// </param>
        /// <param name="workflowIdentifier">
        /// The name or ID of the workflow to schedule
        /// </param>
        /// <param name="scheduleId">
        /// Allows you to specify a custom schedule ID. If not provided, a random ID will be generated.
        /// </param>
        /// <param name="deploymentName">
        /// Name of the deployment to route this schedule to
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WorkflowScheduleRequest(
            global::Mistral.ScheduleDefinition schedule,
            global::System.Guid? workflowRegistrationId,
            global::System.Guid? workflowVersionId,
            string? workflowIdentifier,
            string? scheduleId,
            string? deploymentName)
        {
            this.Schedule = schedule ?? throw new global::System.ArgumentNullException(nameof(schedule));
            this.WorkflowRegistrationId = workflowRegistrationId;
            this.WorkflowVersionId = workflowVersionId;
            this.WorkflowIdentifier = workflowIdentifier;
            this.ScheduleId = scheduleId;
            this.DeploymentName = deploymentName;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowScheduleRequest" /> class.
        /// </summary>
        public WorkflowScheduleRequest()
        {
        }
    }
}