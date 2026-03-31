
#nullable enable

namespace Mistral
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ScheduleCalendar
    {
        /// <summary>
        /// Default Value: [{"start":0,"end":0,"step":0}]
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("second")]
        public global::System.Collections.Generic.IList<global::Mistral.ScheduleRange>? Second { get; set; }

        /// <summary>
        /// Default Value: [{"start":0,"end":0,"step":0}]
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("minute")]
        public global::System.Collections.Generic.IList<global::Mistral.ScheduleRange>? Minute { get; set; }

        /// <summary>
        /// Default Value: [{"start":0,"end":0,"step":0}]
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hour")]
        public global::System.Collections.Generic.IList<global::Mistral.ScheduleRange>? Hour { get; set; }

        /// <summary>
        /// Default Value: [{"start":1,"end":31,"step":0}]
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("day_of_month")]
        public global::System.Collections.Generic.IList<global::Mistral.ScheduleRange>? DayOfMonth { get; set; }

        /// <summary>
        /// Default Value: [{"start":1,"end":12,"step":0}]
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("month")]
        public global::System.Collections.Generic.IList<global::Mistral.ScheduleRange>? Month { get; set; }

        /// <summary>
        /// Default Value: []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("year")]
        public global::System.Collections.Generic.IList<global::Mistral.ScheduleRange>? Year { get; set; }

        /// <summary>
        /// Default Value: [{"start":0,"end":6,"step":0}]
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("day_of_week")]
        public global::System.Collections.Generic.IList<global::Mistral.ScheduleRange>? DayOfWeek { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("comment")]
        public string? Comment { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ScheduleCalendar" /> class.
        /// </summary>
        /// <param name="second">
        /// Default Value: [{"start":0,"end":0,"step":0}]
        /// </param>
        /// <param name="minute">
        /// Default Value: [{"start":0,"end":0,"step":0}]
        /// </param>
        /// <param name="hour">
        /// Default Value: [{"start":0,"end":0,"step":0}]
        /// </param>
        /// <param name="dayOfMonth">
        /// Default Value: [{"start":1,"end":31,"step":0}]
        /// </param>
        /// <param name="month">
        /// Default Value: [{"start":1,"end":12,"step":0}]
        /// </param>
        /// <param name="year">
        /// Default Value: []
        /// </param>
        /// <param name="dayOfWeek">
        /// Default Value: [{"start":0,"end":6,"step":0}]
        /// </param>
        /// <param name="comment"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ScheduleCalendar(
            global::System.Collections.Generic.IList<global::Mistral.ScheduleRange>? second,
            global::System.Collections.Generic.IList<global::Mistral.ScheduleRange>? minute,
            global::System.Collections.Generic.IList<global::Mistral.ScheduleRange>? hour,
            global::System.Collections.Generic.IList<global::Mistral.ScheduleRange>? dayOfMonth,
            global::System.Collections.Generic.IList<global::Mistral.ScheduleRange>? month,
            global::System.Collections.Generic.IList<global::Mistral.ScheduleRange>? year,
            global::System.Collections.Generic.IList<global::Mistral.ScheduleRange>? dayOfWeek,
            string? comment)
        {
            this.Second = second;
            this.Minute = minute;
            this.Hour = hour;
            this.DayOfMonth = dayOfMonth;
            this.Month = month;
            this.Year = year;
            this.DayOfWeek = dayOfWeek;
            this.Comment = comment;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ScheduleCalendar" /> class.
        /// </summary>
        public ScheduleCalendar()
        {
        }
    }
}