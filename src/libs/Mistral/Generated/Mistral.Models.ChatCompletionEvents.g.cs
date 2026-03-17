
#nullable enable

namespace Mistral
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatCompletionEvents
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completion_events")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Mistral.FeedResultChatCompletionEventPreview CompletionEvents { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionEvents" /> class.
        /// </summary>
        /// <param name="completionEvents"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatCompletionEvents(
            global::Mistral.FeedResultChatCompletionEventPreview completionEvents)
        {
            this.CompletionEvents = completionEvents ?? throw new global::System.ArgumentNullException(nameof(completionEvents));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionEvents" /> class.
        /// </summary>
        public ChatCompletionEvents()
        {
        }
    }
}