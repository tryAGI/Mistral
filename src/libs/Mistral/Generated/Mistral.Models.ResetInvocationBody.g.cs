
#nullable enable

namespace Mistral
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResetInvocationBody
    {
        /// <summary>
        /// The event ID to reset the workflow execution to
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("event_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int EventId { get; set; }

        /// <summary>
        /// Reason for resetting the workflow execution
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reason")]
        public string? Reason { get; set; }

        /// <summary>
        /// Whether to exclude signals that happened after the reset point<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("exclude_signals")]
        public bool? ExcludeSignals { get; set; }

        /// <summary>
        /// Whether to exclude updates that happened after the reset point<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("exclude_updates")]
        public bool? ExcludeUpdates { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResetInvocationBody" /> class.
        /// </summary>
        /// <param name="eventId">
        /// The event ID to reset the workflow execution to
        /// </param>
        /// <param name="reason">
        /// Reason for resetting the workflow execution
        /// </param>
        /// <param name="excludeSignals">
        /// Whether to exclude signals that happened after the reset point<br/>
        /// Default Value: false
        /// </param>
        /// <param name="excludeUpdates">
        /// Whether to exclude updates that happened after the reset point<br/>
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResetInvocationBody(
            int eventId,
            string? reason,
            bool? excludeSignals,
            bool? excludeUpdates)
        {
            this.EventId = eventId;
            this.Reason = reason;
            this.ExcludeSignals = excludeSignals;
            this.ExcludeUpdates = excludeUpdates;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResetInvocationBody" /> class.
        /// </summary>
        public ResetInvocationBody()
        {
        }
    }
}