
#nullable enable

namespace Mistral
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GuardrailConfig
    {
        /// <summary>
        /// If true, return HTTP 403 and block request in the event of a server-side error<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("block_on_error")]
        public bool? BlockOnError { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("moderation_llm_v1")]
        public global::Mistral.ModerationLLMV1Config? ModerationLlmV1 { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GuardrailConfig" /> class.
        /// </summary>
        /// <param name="blockOnError">
        /// If true, return HTTP 403 and block request in the event of a server-side error<br/>
        /// Default Value: false
        /// </param>
        /// <param name="moderationLlmV1"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GuardrailConfig(
            bool? blockOnError,
            global::Mistral.ModerationLLMV1Config? moderationLlmV1)
        {
            this.BlockOnError = blockOnError;
            this.ModerationLlmV1 = moderationLlmV1;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GuardrailConfig" /> class.
        /// </summary>
        public GuardrailConfig()
        {
        }
    }
}