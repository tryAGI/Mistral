
#nullable enable

namespace Mistral
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FunctionResultEntry
    {
        /// <summary>
        /// Default Value: entry
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        public string? Object { get; set; }

        /// <summary>
        /// Default Value: function.result
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
        [global::System.Text.Json.Serialization.JsonPropertyName("completed_at")]
        public global::System.DateTime? CompletedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_call_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public string ToolCallId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("result")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public string Result { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FunctionResultEntry" /> class.
        /// </summary>
        /// <param name="object">
        /// Default Value: entry
        /// </param>
        /// <param name="type">
        /// Default Value: function.result
        /// </param>
        /// <param name="createdAt"></param>
        /// <param name="completedAt"></param>
        /// <param name="id"></param>
        /// <param name="toolCallId"></param>
        /// <param name="result"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FunctionResultEntry(
            string toolCallId,
            string result,
            string? @object,
            string? type,
            global::System.DateTime? createdAt,
            global::System.DateTime? completedAt,
            string? id)
        {
            this.ToolCallId = toolCallId ?? throw new global::System.ArgumentNullException(nameof(toolCallId));
            this.Result = result ?? throw new global::System.ArgumentNullException(nameof(result));
            this.Object = @object;
            this.Type = type;
            this.CreatedAt = createdAt;
            this.CompletedAt = completedAt;
            this.Id = id;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FunctionResultEntry" /> class.
        /// </summary>
        public FunctionResultEntry()
        {
        }
    }
}