
#nullable enable

namespace Mistral
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ConversationUsageInfo
    {
        /// <summary>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completion_tokens")]
        public int? CompletionTokens { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("connector_tokens")]
        public int? ConnectorTokens { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("connectors")]
        public global::System.Collections.Generic.Dictionary<string, int>? Connectors { get; set; }

        /// <summary>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_tokens")]
        public int? PromptTokens { get; set; }

        /// <summary>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_tokens")]
        public int? TotalTokens { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationUsageInfo" /> class.
        /// </summary>
        /// <param name="completionTokens">
        /// Default Value: 0
        /// </param>
        /// <param name="connectorTokens"></param>
        /// <param name="connectors"></param>
        /// <param name="promptTokens">
        /// Default Value: 0
        /// </param>
        /// <param name="totalTokens">
        /// Default Value: 0
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ConversationUsageInfo(
            int? completionTokens,
            int? connectorTokens,
            global::System.Collections.Generic.Dictionary<string, int>? connectors,
            int? promptTokens,
            int? totalTokens)
        {
            this.CompletionTokens = completionTokens;
            this.ConnectorTokens = connectorTokens;
            this.Connectors = connectors;
            this.PromptTokens = promptTokens;
            this.TotalTokens = totalTokens;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationUsageInfo" /> class.
        /// </summary>
        public ConversationUsageInfo()
        {
        }
    }
}