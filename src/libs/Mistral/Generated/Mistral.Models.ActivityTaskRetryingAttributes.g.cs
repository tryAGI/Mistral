
#nullable enable

namespace Mistral
{
    /// <summary>
    /// Attributes for activity task retrying events.
    /// </summary>
    public sealed partial class ActivityTaskRetryingAttributes
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
        /// The attempt number that failed (1-indexed).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("attempt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Attempt { get; set; }

        /// <summary>
        /// Details about the failure that caused the retry.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("failure")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Mistral.Failure Failure { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ActivityTaskRetryingAttributes" /> class.
        /// </summary>
        /// <param name="taskId">
        /// Unique identifier for the activity task within the workflow.
        /// </param>
        /// <param name="activityName">
        /// The registered name of the activity being executed.
        /// </param>
        /// <param name="attempt">
        /// The attempt number that failed (1-indexed).
        /// </param>
        /// <param name="failure">
        /// Details about the failure that caused the retry.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ActivityTaskRetryingAttributes(
            string taskId,
            string activityName,
            int attempt,
            global::Mistral.Failure failure)
        {
            this.TaskId = taskId ?? throw new global::System.ArgumentNullException(nameof(taskId));
            this.ActivityName = activityName ?? throw new global::System.ArgumentNullException(nameof(activityName));
            this.Attempt = attempt;
            this.Failure = failure ?? throw new global::System.ArgumentNullException(nameof(failure));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ActivityTaskRetryingAttributes" /> class.
        /// </summary>
        public ActivityTaskRetryingAttributes()
        {
        }
    }
}