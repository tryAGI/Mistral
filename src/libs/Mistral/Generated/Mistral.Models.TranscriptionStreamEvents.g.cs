
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
        [global::System.Text.Json.Serialization.JsonPropertyName("event")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Mistral.JsonConverters.TranscriptionStreamEventTypesJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public global::Mistral.TranscriptionStreamEventTypes Event { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Mistral.JsonConverters.Data2JsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public global::Mistral.Data2 Data { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TranscriptionStreamEvents" /> class.
        /// </summary>
        /// <param name="event"></param>
        /// <param name="data"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TranscriptionStreamEvents(
            global::Mistral.TranscriptionStreamEventTypes @event,
            global::Mistral.Data2 data)
        {
            this.Event = @event;
            this.Data = data;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TranscriptionStreamEvents" /> class.
        /// </summary>
        public TranscriptionStreamEvents()
        {
        }
    }
}