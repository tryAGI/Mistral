
#nullable enable

namespace Mistral
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FunctionCallEntry
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("arguments")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Mistral.JsonConverters.FunctionCallEntryArgumentsJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Mistral.FunctionCallEntryArguments Arguments { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completed_at")]
        public global::System.DateTime? CompletedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Default Value: entry
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Mistral.JsonConverters.FunctionCallEntryObjectJsonConverter))]
        public global::Mistral.FunctionCallEntryObject? Object { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_call_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ToolCallId { get; set; }

        /// <summary>
        /// Default Value: function.call
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Mistral.JsonConverters.FunctionCallEntryTypeJsonConverter))]
        public global::Mistral.FunctionCallEntryType? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FunctionCallEntry" /> class.
        /// </summary>
        /// <param name="arguments"></param>
        /// <param name="completedAt"></param>
        /// <param name="createdAt"></param>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="object">
        /// Default Value: entry
        /// </param>
        /// <param name="toolCallId"></param>
        /// <param name="type">
        /// Default Value: function.call
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FunctionCallEntry(
            global::Mistral.FunctionCallEntryArguments arguments,
            string name,
            string toolCallId,
            global::System.DateTime? completedAt,
            global::System.DateTime? createdAt,
            string? id,
            global::Mistral.FunctionCallEntryObject? @object,
            global::Mistral.FunctionCallEntryType? type)
        {
            this.Arguments = arguments;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.ToolCallId = toolCallId ?? throw new global::System.ArgumentNullException(nameof(toolCallId));
            this.CompletedAt = completedAt;
            this.CreatedAt = createdAt;
            this.Id = id;
            this.Object = @object;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FunctionCallEntry" /> class.
        /// </summary>
        public FunctionCallEntry()
        {
        }
    }
}