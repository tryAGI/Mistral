
#nullable enable

namespace Mistral
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WorkflowScheduleResponse
    {
        /// <summary>
        /// The ID of the schedule
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("schedule_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ScheduleId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowScheduleResponse" /> class.
        /// </summary>
        /// <param name="scheduleId">
        /// The ID of the schedule
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WorkflowScheduleResponse(
            string scheduleId)
        {
            this.ScheduleId = scheduleId ?? throw new global::System.ArgumentNullException(nameof(scheduleId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowScheduleResponse" /> class.
        /// </summary>
        public WorkflowScheduleResponse()
        {
        }
    }
}