
#nullable enable

namespace Mistral
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FeedResultChatCompletionEventPreview
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("results")]
        public global::System.Collections.Generic.IList<global::Mistral.ChatCompletionEventPreview>? Results { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("next")]
        public string? Next { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cursor")]
        public string? Cursor { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FeedResultChatCompletionEventPreview" /> class.
        /// </summary>
        /// <param name="results"></param>
        /// <param name="next"></param>
        /// <param name="cursor"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FeedResultChatCompletionEventPreview(
            global::System.Collections.Generic.IList<global::Mistral.ChatCompletionEventPreview>? results,
            string? next,
            string? cursor)
        {
            this.Results = results;
            this.Next = next;
            this.Cursor = cursor;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FeedResultChatCompletionEventPreview" /> class.
        /// </summary>
        public FeedResultChatCompletionEventPreview()
        {
        }
    }
}