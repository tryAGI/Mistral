
#nullable enable

namespace Mistral
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SchedulePolicy
    {
        /// <summary>
        /// After a Temporal server is unavailable, amount of time in seconds in the past to execute missed actions.<br/>
        /// Default Value: 31536000
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("catchup_window_seconds")]
        public int? CatchupWindowSeconds { get; set; }

        /// <summary>
        /// Policy controlling what to do when a workflow is already running.<br/>
        /// Default Value: 1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("overlap")]
        public int? Overlap { get; set; }

        /// <summary>
        /// Whether to pause the schedule after a workflow failure.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pause_on_failure")]
        public bool? PauseOnFailure { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SchedulePolicy" /> class.
        /// </summary>
        /// <param name="catchupWindowSeconds">
        /// After a Temporal server is unavailable, amount of time in seconds in the past to execute missed actions.<br/>
        /// Default Value: 31536000
        /// </param>
        /// <param name="overlap">
        /// Policy controlling what to do when a workflow is already running.<br/>
        /// Default Value: 1
        /// </param>
        /// <param name="pauseOnFailure">
        /// Whether to pause the schedule after a workflow failure.<br/>
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SchedulePolicy(
            int? catchupWindowSeconds,
            int? overlap,
            bool? pauseOnFailure)
        {
            this.CatchupWindowSeconds = catchupWindowSeconds;
            this.Overlap = overlap;
            this.PauseOnFailure = pauseOnFailure;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SchedulePolicy" /> class.
        /// </summary>
        public SchedulePolicy()
        {
        }
    }
}