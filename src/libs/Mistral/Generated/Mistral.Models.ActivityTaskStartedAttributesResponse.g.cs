
#nullable enable

namespace Mistral
{
    /// <summary>
    /// Attributes for activity task started events.
    /// </summary>
    public sealed partial class ActivityTaskStartedAttributesResponse
    {
        /// <summary>
        /// Unique identifier for the activity task within the workflow.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("task_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TaskId { get; set; }

        /// <summary>
        /// The registered name of the activity being executed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("activity_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ActivityName { get; set; }

        /// <summary>
        /// The input arguments passed to the activity.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Mistral.JSONPayloadResponse Input { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ActivityTaskStartedAttributesResponse" /> class.
        /// </summary>
        /// <param name="taskId">
        /// Unique identifier for the activity task within the workflow.
        /// </param>
        /// <param name="activityName">
        /// The registered name of the activity being executed.
        /// </param>
        /// <param name="input">
        /// The input arguments passed to the activity.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ActivityTaskStartedAttributesResponse(
            string taskId,
            string activityName,
            global::Mistral.JSONPayloadResponse input)
        {
            this.TaskId = taskId ?? throw new global::System.ArgumentNullException(nameof(taskId));
            this.ActivityName = activityName ?? throw new global::System.ArgumentNullException(nameof(activityName));
            this.Input = input ?? throw new global::System.ArgumentNullException(nameof(input));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ActivityTaskStartedAttributesResponse" /> class.
        /// </summary>
        public ActivityTaskStartedAttributesResponse()
        {
        }
    }
}