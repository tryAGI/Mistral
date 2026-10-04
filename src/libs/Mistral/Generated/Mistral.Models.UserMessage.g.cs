
#nullable enable

namespace Mistral
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class UserMessage
    {
        /// <summary>
        /// Default Value: user
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        public string? Role { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Mistral.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<global::Mistral.ContentChunk>>))]
        public global::Mistral.AnyOf<string, global::System.Collections.Generic.IList<global::Mistral.ContentChunk>>? Content { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserMessage" /> class.
        /// </summary>
        /// <param name="role">
        /// Default Value: user
        /// </param>
        /// <param name="content"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserMessage(
            string? role,
            global::Mistral.AnyOf<string, global::System.Collections.Generic.IList<global::Mistral.ContentChunk>>? content)
        {
            this.Role = role;
            this.Content = content;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserMessage" /> class.
        /// </summary>
        public UserMessage()
        {
        }

    }
}