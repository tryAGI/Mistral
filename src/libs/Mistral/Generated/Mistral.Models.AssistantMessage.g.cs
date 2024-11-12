
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Mistral
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AssistantMessage
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Mistral.JsonConverters.AnyOfJsonConverterFactory2))]
        public global::Mistral.AnyOf<string, global::System.Collections.Generic.IList<global::Mistral.ContentChunk>>? Content { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prefix")]
        public bool? Prefix { get; set; }

        /// <summary>
        /// Default Value: assistant
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Mistral.JsonConverters.AssistantMessageRoleJsonConverter))]
        public global::Mistral.AssistantMessageRole? Role { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_calls")]
        public global::System.Collections.Generic.IList<global::Mistral.ToolCall>? ToolCalls { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AssistantMessage" /> class.
        /// </summary>
        /// <param name="content"></param>
        /// <param name="prefix">
        /// Default Value: false
        /// </param>
        /// <param name="role">
        /// Default Value: assistant
        /// </param>
        /// <param name="toolCalls"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public AssistantMessage(
            global::Mistral.AnyOf<string, global::System.Collections.Generic.IList<global::Mistral.ContentChunk>>? content,
            bool? prefix,
            global::Mistral.AssistantMessageRole? role,
            global::System.Collections.Generic.IList<global::Mistral.ToolCall>? toolCalls)
        {
            this.Content = content;
            this.Prefix = prefix;
            this.Role = role;
            this.ToolCalls = toolCalls;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AssistantMessage" /> class.
        /// </summary>
        public AssistantMessage()
        {
        }
    }
}