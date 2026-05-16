
#nullable enable

namespace Mistral.Realtime
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RealtimeTranscriptionSessionCreated
    {
        /// <summary>
        /// Default Value: session.created
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("session")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Mistral.Realtime.RealtimeTranscriptionSession Session { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeTranscriptionSessionCreated" /> class.
        /// </summary>
        /// <param name="session"></param>
        /// <param name="type">
        /// Default Value: session.created
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RealtimeTranscriptionSessionCreated(
            global::Mistral.Realtime.RealtimeTranscriptionSession session,
            string? type)
        {
            this.Type = type;
            this.Session = session ?? throw new global::System.ArgumentNullException(nameof(session));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeTranscriptionSessionCreated" /> class.
        /// </summary>
        public RealtimeTranscriptionSessionCreated()
        {
        }

    }
}