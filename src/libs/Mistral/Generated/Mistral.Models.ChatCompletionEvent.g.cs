
#nullable enable

namespace Mistral
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatCompletionEvent
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
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled_tools")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<object> EnabledTools { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request_messages")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<object> RequestMessages { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("response_messages")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<object> ResponseMessages { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("nb_messages")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int NbMessages { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chat_transcription_events")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Mistral.ChatTranscriptionEvent> ChatTranscriptionEvents { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionEvent" /> class.
        /// </summary>
        /// <param name="eventId"></param>
        /// <param name="correlationId"></param>
        /// <param name="createdAt"></param>
        /// <param name="extraFields"></param>
        /// <param name="nbInputTokens"></param>
        /// <param name="nbOutputTokens"></param>
        /// <param name="enabledTools"></param>
        /// <param name="requestMessages"></param>
        /// <param name="responseMessages"></param>
        /// <param name="nbMessages"></param>
        /// <param name="chatTranscriptionEvents"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatCompletionEvent(
            string eventId,
            string correlationId,
            global::System.DateTime createdAt,
            object extraFields,
            int nbInputTokens,
            int nbOutputTokens,
            global::System.Collections.Generic.IList<object> enabledTools,
            global::System.Collections.Generic.IList<object> requestMessages,
            global::System.Collections.Generic.IList<object> responseMessages,
            int nbMessages,
            global::System.Collections.Generic.IList<global::Mistral.ChatTranscriptionEvent> chatTranscriptionEvents)
        {
            this.EventId = eventId ?? throw new global::System.ArgumentNullException(nameof(eventId));
            this.CorrelationId = correlationId ?? throw new global::System.ArgumentNullException(nameof(correlationId));
            this.CreatedAt = createdAt;
            this.ExtraFields = extraFields ?? throw new global::System.ArgumentNullException(nameof(extraFields));
            this.NbInputTokens = nbInputTokens;
            this.NbOutputTokens = nbOutputTokens;
            this.EnabledTools = enabledTools ?? throw new global::System.ArgumentNullException(nameof(enabledTools));
            this.RequestMessages = requestMessages ?? throw new global::System.ArgumentNullException(nameof(requestMessages));
            this.ResponseMessages = responseMessages ?? throw new global::System.ArgumentNullException(nameof(responseMessages));
            this.NbMessages = nbMessages;
            this.ChatTranscriptionEvents = chatTranscriptionEvents ?? throw new global::System.ArgumentNullException(nameof(chatTranscriptionEvents));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionEvent" /> class.
        /// </summary>
        public ChatCompletionEvent()
        {
        }
    }
}