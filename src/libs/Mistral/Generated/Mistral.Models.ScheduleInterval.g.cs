
#nullable enable

namespace Mistral
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ScheduleInterval
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("every")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Every { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("offset")]
        public string? Offset { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ScheduleInterval" /> class.
        /// </summary>
        /// <param name="every"></param>
        /// <param name="offset"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ScheduleInterval(
            string every,
            string? offset)
        {
            this.Every = every ?? throw new global::System.ArgumentNullException(nameof(every));
            this.Offset = offset;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ScheduleInterval" /> class.
        /// </summary>
        public ScheduleInterval()
        {
        }
    }
}