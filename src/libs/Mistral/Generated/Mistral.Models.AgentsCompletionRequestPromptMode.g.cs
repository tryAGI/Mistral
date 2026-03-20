
#nullable enable

namespace Mistral
{
    /// <summary>
    /// Allows toggling between the reasoning mode and no system prompt. When set to `reasoning` the system prompt for reasoning models will be used. **Deprecated for reasoning models - use `reasoning_effort` parameter instead.**
    /// </summary>
    public sealed partial class AgentsCompletionRequestPromptMode
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}