
#nullable enable

namespace Mistral
{
    /// <summary>
    /// A list of guardrail configurations to apply to this request. Each guardrail specifies a moderation type, categories with thresholds to evaluate, and an action to take on violation.<br/>
    /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
    /// </summary>
    public sealed partial class ChatCompletionRequestGuardrails
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}