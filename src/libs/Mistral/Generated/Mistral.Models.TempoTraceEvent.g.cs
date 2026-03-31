
#nullable enable

namespace Mistral
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TempoTraceEvent
    {
        /// <summary>
        /// The name of the event
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// The time of the event in Unix nano
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timeUnixNano")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TimeUnixNano { get; set; }

        /// <summary>
        /// The attributes of the event
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("attributes")]
        public global::System.Collections.Generic.IList<global::Mistral.TempoTraceAttribute>? Attributes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TempoTraceEvent" /> class.
        /// </summary>
        /// <param name="name">
        /// The name of the event
        /// </param>
        /// <param name="timeUnixNano">
        /// The time of the event in Unix nano
        /// </param>
        /// <param name="attributes">
        /// The attributes of the event
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TempoTraceEvent(
            string name,
            string timeUnixNano,
            global::System.Collections.Generic.IList<global::Mistral.TempoTraceAttribute>? attributes)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.TimeUnixNano = timeUnixNano ?? throw new global::System.ArgumentNullException(nameof(timeUnixNano));
            this.Attributes = attributes;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TempoTraceEvent" /> class.
        /// </summary>
        public TempoTraceEvent()
        {
        }
    }
}