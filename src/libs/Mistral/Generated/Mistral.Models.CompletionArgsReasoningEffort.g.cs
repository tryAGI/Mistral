
#nullable enable

namespace Mistral
{
    /// <summary>
    /// Controls the reasoning effort level for reasoning models. "high" enables comprehensive reasoning traces, "none" disables reasoning effort.
    /// </summary>
    public sealed partial class CompletionArgsReasoningEffort
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}