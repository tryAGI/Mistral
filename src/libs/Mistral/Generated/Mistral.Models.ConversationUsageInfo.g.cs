
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
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_tokens")]
        public int? PromptTokens { get; set; }

        /// <summary>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completion_tokens")]
        public int? CompletionTokens { get; set; }

        /// <summary>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_tokens")]
        public int? TotalTokens { get; set; }

        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("connector_tokens")]
        public int? ConnectorTokens { get; set; }

        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("connectors")]
        public global::System.Collections.Generic.Dictionary<string, int>? Connectors { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationUsageInfo" /> class.
        /// </summary>
        /// <param name="promptTokens">
        /// Default Value: 0
        /// </param>
        /// <param name="completionTokens">
        /// Default Value: 0
        /// </param>
        /// <param name="totalTokens">
        /// Default Value: 0
        /// </param>
        /// <param name="connectorTokens">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="connectors">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ConversationUsageInfo(
            int? promptTokens,
            int? completionTokens,
            int? totalTokens,
            int? connectorTokens,
            global::System.Collections.Generic.Dictionary<string, int>? connectors)
        {
            this.PromptTokens = promptTokens;
            this.CompletionTokens = completionTokens;
            this.TotalTokens = totalTokens;
            this.ConnectorTokens = connectorTokens;
            this.Connectors = connectors;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationUsageInfo" /> class.
        /// </summary>
        public ConversationUsageInfo()
        {
        }
    }
}