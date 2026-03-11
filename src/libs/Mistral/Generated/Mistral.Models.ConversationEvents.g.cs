
#nullable enable

namespace Mistral
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ConversationEvents
    {
        /// <summary>
        /// Server side events sent when streaming a conversation response.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("event")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Mistral.JsonConverters.SSETypesJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public global::Mistral.SSETypes Event { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Mistral.JsonConverters.DataJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public global::Mistral.Data Data { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationEvents" /> class.
        /// </summary>
        /// <param name="event">
        /// Server side events sent when streaming a conversation response.
        /// </param>
        /// <param name="data"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ConversationEvents(
            global::Mistral.SSETypes @event,
            global::Mistral.Data data)
        {
            this.Event = @event;
            this.Data = data;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationEvents" /> class.
        /// </summary>
        public ConversationEvents()
        {
        }
    }
}