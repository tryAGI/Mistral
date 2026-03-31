
#nullable enable

namespace Mistral
{
    /// <summary>
    /// Specification of the times scheduled actions may occur.<br/>
    /// The times are the union of :py:attr:`calendars`, :py:attr:`intervals`, and<br/>
    /// :py:attr:`cron_expressions` excluding anything in :py:attr:`skip`.<br/>
    /// Used for input where schedule_id is optional (can be provided or auto-generated).
    /// </summary>
    public sealed partial class ScheduleDefinition
    {
        /// <summary>
        /// Input to provide to the workflow when starting it.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Input { get; set; }

        /// <summary>
        /// Calendar-based specification of times.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("calendars")]
        public global::System.Collections.Generic.IList<global::Mistral.ScheduleCalendar>? Calendars { get; set; }

        /// <summary>
        /// Interval-based specification of times.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("intervals")]
        public global::System.Collections.Generic.IList<global::Mistral.ScheduleInterval>? Intervals { get; set; }

        /// <summary>
        /// Cron-based specification of times.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cron_expressions")]
        public global::System.Collections.Generic.IList<string>? CronExpressions { get; set; }

        /// <summary>
        /// Set of calendar times to skip.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("skip")]
        public global::System.Collections.Generic.IList<global::Mistral.ScheduleCalendar>? Skip { get; set; }

        /// <summary>
        /// Time after which the first action may be run.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_at")]
        public global::System.DateTime? StartAt { get; set; }

        /// <summary>
        /// Time after which no more actions will be run.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_at")]
        public global::System.DateTime? EndAt { get; set; }

        /// <summary>
        /// Jitter to apply each action.<br/>
        /// An action's scheduled time will be incremented by a random value between 0<br/>
        /// and this value if present (but not past the next schedule).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("jitter")]
        public string? Jitter { get; set; }

        /// <summary>
        /// IANA time zone name, for example ``US/Central``.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("time_zone_name")]
        public string? TimeZoneName { get; set; }

        /// <summary>
        /// Policy for the schedule.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("policy")]
        public global::Mistral.SchedulePolicy? Policy { get; set; }

        /// <summary>
        /// Unique identifier for the schedule.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("schedule_id")]
        public string? ScheduleId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ScheduleDefinition" /> class.
        /// </summary>
        /// <param name="input">
        /// Input to provide to the workflow when starting it.
        /// </param>
        /// <param name="calendars">
        /// Calendar-based specification of times.
        /// </param>
        /// <param name="intervals">
        /// Interval-based specification of times.
        /// </param>
        /// <param name="cronExpressions">
        /// Cron-based specification of times.
        /// </param>
        /// <param name="skip">
        /// Set of calendar times to skip.
        /// </param>
        /// <param name="startAt">
        /// Time after which the first action may be run.
        /// </param>
        /// <param name="endAt">
        /// Time after which no more actions will be run.
        /// </param>
        /// <param name="jitter">
        /// Jitter to apply each action.<br/>
        /// An action's scheduled time will be incremented by a random value between 0<br/>
        /// and this value if present (but not past the next schedule).
        /// </param>
        /// <param name="timeZoneName">
        /// IANA time zone name, for example ``US/Central``.
        /// </param>
        /// <param name="policy">
        /// Policy for the schedule.
        /// </param>
        /// <param name="scheduleId">
        /// Unique identifier for the schedule.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ScheduleDefinition(
            object input,
            global::System.Collections.Generic.IList<global::Mistral.ScheduleCalendar>? calendars,
            global::System.Collections.Generic.IList<global::Mistral.ScheduleInterval>? intervals,
            global::System.Collections.Generic.IList<string>? cronExpressions,
            global::System.Collections.Generic.IList<global::Mistral.ScheduleCalendar>? skip,
            global::System.DateTime? startAt,
            global::System.DateTime? endAt,
            string? jitter,
            string? timeZoneName,
            global::Mistral.SchedulePolicy? policy,
            string? scheduleId)
        {
            this.Input = input ?? throw new global::System.ArgumentNullException(nameof(input));
            this.Calendars = calendars;
            this.Intervals = intervals;
            this.CronExpressions = cronExpressions;
            this.Skip = skip;
            this.StartAt = startAt;
            this.EndAt = endAt;
            this.Jitter = jitter;
            this.TimeZoneName = timeZoneName;
            this.Policy = policy;
            this.ScheduleId = scheduleId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ScheduleDefinition" /> class.
        /// </summary>
        public ScheduleDefinition()
        {
        }
    }
}