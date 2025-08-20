
#nullable enable

namespace Mistral
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TranscriptionStreamEvents
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Mistral.JsonConverters.Data2JsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Mistral.Data2 Data { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("event")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Mistral.JsonConverters.TranscriptionStreamEventTypesJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Mistral.TranscriptionStreamEventTypes Event { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TranscriptionStreamEvents" /> class.
        /// </summary>
        /// <param name="data"></param>
        /// <param name="event"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TranscriptionStreamEvents(
            global::Mistral.Data2 data,
            global::Mistral.TranscriptionStreamEventTypes @event)
        {
            this.Data = data;
            this.Event = @event;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TranscriptionStreamEvents" /> class.
        /// </summary>
        public TranscriptionStreamEvents()
        {
        }
    }
}