
#nullable enable

namespace Mistral
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatCompletionEventPreview
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("event_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EventId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("correlation_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CorrelationId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("extra_fields")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object ExtraFields { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("nb_input_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int NbInputTokens { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("nb_output_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int NbOutputTokens { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionEventPreview" /> class.
        /// </summary>
        /// <param name="eventId"></param>
        /// <param name="correlationId"></param>
        /// <param name="createdAt"></param>
        /// <param name="extraFields"></param>
        /// <param name="nbInputTokens"></param>
        /// <param name="nbOutputTokens"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatCompletionEventPreview(
            string eventId,
            string correlationId,
            global::System.DateTime createdAt,
            object extraFields,
            int nbInputTokens,
            int nbOutputTokens)
        {
            this.EventId = eventId ?? throw new global::System.ArgumentNullException(nameof(eventId));
            this.CorrelationId = correlationId ?? throw new global::System.ArgumentNullException(nameof(correlationId));
            this.CreatedAt = createdAt;
            this.ExtraFields = extraFields ?? throw new global::System.ArgumentNullException(nameof(extraFields));
            this.NbInputTokens = nbInputTokens;
            this.NbOutputTokens = nbOutputTokens;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionEventPreview" /> class.
        /// </summary>
        public ChatCompletionEventPreview()
        {
        }
    }
}