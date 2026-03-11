
#nullable enable

namespace Mistral
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ToolCallConfirmation
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_call_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public string ToolCallId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("confirmation")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Mistral.JsonConverters.ToolCallConfirmationConfirmationJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public global::Mistral.ToolCallConfirmationConfirmation Confirmation { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolCallConfirmation" /> class.
        /// </summary>
        /// <param name="toolCallId"></param>
        /// <param name="confirmation"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ToolCallConfirmation(
            string toolCallId,
            global::Mistral.ToolCallConfirmationConfirmation confirmation)
        {
            this.ToolCallId = toolCallId ?? throw new global::System.ArgumentNullException(nameof(toolCallId));
            this.Confirmation = confirmation;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolCallConfirmation" /> class.
        /// </summary>
        public ToolCallConfirmation()
        {
        }
    }
}