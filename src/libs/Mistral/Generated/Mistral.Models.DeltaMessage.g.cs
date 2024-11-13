
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Mistral
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DeltaMessage
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Mistral.JsonConverters.AnyOfJsonConverter<string, object, global::System.Collections.Generic.IList<global::Mistral.ContentChunk>>))]
        public global::Mistral.AnyOf<string, object, global::System.Collections.Generic.IList<global::Mistral.ContentChunk>>? Content { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        public string? Role { get; set; }

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
        /// Initializes a new instance of the <see cref="DeltaMessage" /> class.
        /// </summary>
        /// <param name="content"></param>
        /// <param name="role"></param>
        /// <param name="toolCalls"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public DeltaMessage(
            global::Mistral.AnyOf<string, object, global::System.Collections.Generic.IList<global::Mistral.ContentChunk>>? content,
            string? role,
            global::System.Collections.Generic.IList<global::Mistral.ToolCall>? toolCalls)
        {
            this.Content = content;
            this.Role = role;
            this.ToolCalls = toolCalls;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeltaMessage" /> class.
        /// </summary>
        public DeltaMessage()
        {
        }
    }
}