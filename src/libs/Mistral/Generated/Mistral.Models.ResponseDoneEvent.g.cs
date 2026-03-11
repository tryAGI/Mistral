
#nullable enable

namespace Mistral
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResponseDoneEvent
    {
        /// <summary>
        /// Default Value: conversation.response.done
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("usage")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public global::Mistral.ConversationUsageInfo Usage { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseDoneEvent" /> class.
        /// </summary>
        /// <param name="type">
        /// Default Value: conversation.response.done
        /// </param>
        /// <param name="createdAt"></param>
        /// <param name="usage"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResponseDoneEvent(
            global::Mistral.ConversationUsageInfo usage,
            string? type,
            global::System.DateTime? createdAt)
        {
            this.Usage = usage ?? throw new global::System.ArgumentNullException(nameof(usage));
            this.Type = type;
            this.CreatedAt = createdAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseDoneEvent" /> class.
        /// </summary>
        public ResponseDoneEvent()
        {
        }
    }
}