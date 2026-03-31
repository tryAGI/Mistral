
#nullable enable

namespace Mistral
{
    /// <summary>
    /// Emitted when an activity task completes successfully.<br/>
    /// Contains timing information about the successful execution.
    /// </summary>
    public sealed partial class ActivityTaskCompletedResponse
    {
        /// <summary>
        /// Unique identifier for this event instance.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("event_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EventId { get; set; }

        /// <summary>
        /// Unix timestamp in nanoseconds when the event was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("event_timestamp")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Mistral.JsonConverters.UnixTimestampJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTimeOffset EventTimestamp { get; set; }

        /// <summary>
        /// Execution ID of the root workflow that initiated this execution chain.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("root_workflow_exec_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RootWorkflowExecId { get; set; }

        /// <summary>
        /// Execution ID of the parent workflow that initiated this execution. If this is a root workflow, this field is not set.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parent_workflow_exec_id")]
        public string? ParentWorkflowExecId { get; set; }

        /// <summary>
        /// Execution ID of the workflow that emitted this event.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workflow_exec_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string WorkflowExecId { get; set; }

        /// <summary>
        /// Run ID of the workflow execution. Changes on continue-as-new while workflow_exec_id stays the same.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workflow_run_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string WorkflowRunId { get; set; }

        /// <summary>
        /// The registered name of the workflow that emitted this event.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workflow_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string WorkflowName { get; set; }

        /// <summary>
        /// Event type discriminator.<br/>
        /// Default Value: ACTIVITY_TASK_COMPLETED
        /// </summary>
        /// <default>"ACTIVITY_TASK_COMPLETED"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("event_type")]
        public string EventType { get; set; } = "ACTIVITY_TASK_COMPLETED";

        /// <summary>
        /// Event-specific attributes.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("attributes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Mistral.ActivityTaskCompletedAttributesResponse Attributes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ActivityTaskCompletedResponse" /> class.
        /// </summary>
        /// <param name="eventId">
        /// Unique identifier for this event instance.
        /// </param>
        /// <param name="eventTimestamp">
        /// Unix timestamp in nanoseconds when the event was created.
        /// </param>
        /// <param name="rootWorkflowExecId">
        /// Execution ID of the root workflow that initiated this execution chain.
        /// </param>
        /// <param name="workflowExecId">
        /// Execution ID of the workflow that emitted this event.
        /// </param>
        /// <param name="workflowRunId">
        /// Run ID of the workflow execution. Changes on continue-as-new while workflow_exec_id stays the same.
        /// </param>
        /// <param name="workflowName">
        /// The registered name of the workflow that emitted this event.
        /// </param>
        /// <param name="attributes">
        /// Event-specific attributes.
        /// </param>
        /// <param name="parentWorkflowExecId">
        /// Execution ID of the parent workflow that initiated this execution. If this is a root workflow, this field is not set.
        /// </param>
        /// <param name="eventType">
        /// Event type discriminator.<br/>
        /// Default Value: ACTIVITY_TASK_COMPLETED
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ActivityTaskCompletedResponse(
            string eventId,
            global::System.DateTimeOffset eventTimestamp,
            string rootWorkflowExecId,
            string workflowExecId,
            string workflowRunId,
            string workflowName,
            global::Mistral.ActivityTaskCompletedAttributesResponse attributes,
            string? parentWorkflowExecId,
            string eventType = "ACTIVITY_TASK_COMPLETED")
        {
            this.EventId = eventId ?? throw new global::System.ArgumentNullException(nameof(eventId));
            this.EventTimestamp = eventTimestamp;
            this.RootWorkflowExecId = rootWorkflowExecId ?? throw new global::System.ArgumentNullException(nameof(rootWorkflowExecId));
            this.ParentWorkflowExecId = parentWorkflowExecId;
            this.WorkflowExecId = workflowExecId ?? throw new global::System.ArgumentNullException(nameof(workflowExecId));
            this.WorkflowRunId = workflowRunId ?? throw new global::System.ArgumentNullException(nameof(workflowRunId));
            this.WorkflowName = workflowName ?? throw new global::System.ArgumentNullException(nameof(workflowName));
            this.EventType = eventType;
            this.Attributes = attributes ?? throw new global::System.ArgumentNullException(nameof(attributes));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ActivityTaskCompletedResponse" /> class.
        /// </summary>
        public ActivityTaskCompletedResponse()
        {
        }
    }
}