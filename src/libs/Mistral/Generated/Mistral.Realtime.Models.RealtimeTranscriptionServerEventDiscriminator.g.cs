
#nullable enable

namespace Mistral.Realtime
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RealtimeTranscriptionServerEventDiscriminator
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Mistral.Realtime.JsonConverters.RealtimeTranscriptionServerEventDiscriminatorTypeJsonConverter))]
        public global::Mistral.Realtime.RealtimeTranscriptionServerEventDiscriminatorType? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeTranscriptionServerEventDiscriminator" /> class.
        /// </summary>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RealtimeTranscriptionServerEventDiscriminator(
            global::Mistral.Realtime.RealtimeTranscriptionServerEventDiscriminatorType? type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeTranscriptionServerEventDiscriminator" /> class.
        /// </summary>
        public RealtimeTranscriptionServerEventDiscriminator()
        {
        }

    }
}