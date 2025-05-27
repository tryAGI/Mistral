
#nullable enable

namespace Mistral
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FunctionResultEntry
    {
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
        /// Default Value: entry
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Mistral.JsonConverters.FunctionResultEntryObjectJsonConverter))]
        public global::Mistral.FunctionResultEntryObject? Object { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("result")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Result { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_call_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ToolCallId { get; set; }

        /// <summary>
        /// Default Value: function.result
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Mistral.JsonConverters.FunctionResultEntryTypeJsonConverter))]
        public global::Mistral.FunctionResultEntryType? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FunctionResultEntry" /> class.
        /// </summary>
        /// <param name="completedAt"></param>
        /// <param name="createdAt"></param>
        /// <param name="id"></param>
        /// <param name="object">
        /// Default Value: entry
        /// </param>
        /// <param name="result"></param>
        /// <param name="toolCallId"></param>
        /// <param name="type">
        /// Default Value: function.result
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FunctionResultEntry(
            string result,
            string toolCallId,
            global::System.DateTime? completedAt,
            global::System.DateTime? createdAt,
            string? id,
            global::Mistral.FunctionResultEntryObject? @object,
            global::Mistral.FunctionResultEntryType? type)
        {
            this.Result = result ?? throw new global::System.ArgumentNullException(nameof(result));
            this.ToolCallId = toolCallId ?? throw new global::System.ArgumentNullException(nameof(toolCallId));
            this.CompletedAt = completedAt;
            this.CreatedAt = createdAt;
            this.Id = id;
            this.Object = @object;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FunctionResultEntry" /> class.
        /// </summary>
        public FunctionResultEntry()
        {
        }
    }
}