
#nullable enable

namespace Mistral
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ConversationEvents
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Mistral.JsonConverters.DataJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Mistral.Data Data { get; set; }

        /// <summary>
        /// Server side events sent when streaming a conversation response.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("event")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Mistral.JsonConverters.SSETypesJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Mistral.SSETypes Event { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationEvents" /> class.
        /// </summary>
        /// <param name="data"></param>
        /// <param name="event">
        /// Server side events sent when streaming a conversation response.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ConversationEvents(
            global::Mistral.Data data,
            global::Mistral.SSETypes @event)
        {
            this.Data = data;
            this.Event = @event;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationEvents" /> class.
        /// </summary>
        public ConversationEvents()
        {
        }
    }
}