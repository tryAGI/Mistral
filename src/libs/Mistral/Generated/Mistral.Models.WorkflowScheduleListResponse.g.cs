
#nullable enable

namespace Mistral
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WorkflowScheduleListResponse
    {
        /// <summary>
        /// A list of workflow schedules
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("schedules")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Mistral.ScheduleDefinitionOutput> Schedules { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowScheduleListResponse" /> class.
        /// </summary>
        /// <param name="schedules">
        /// A list of workflow schedules
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WorkflowScheduleListResponse(
            global::System.Collections.Generic.IList<global::Mistral.ScheduleDefinitionOutput> schedules)
        {
            this.Schedules = schedules ?? throw new global::System.ArgumentNullException(nameof(schedules));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowScheduleListResponse" /> class.
        /// </summary>
        public WorkflowScheduleListResponse()
        {
        }
    }
}