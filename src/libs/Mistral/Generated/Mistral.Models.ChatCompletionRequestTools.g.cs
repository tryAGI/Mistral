
#nullable enable

namespace Mistral
{
    /// <summary>
    /// A list of tools the model may call. Use this to provide a list of functions the model may generate JSON inputs for.
    /// </summary>
    public sealed partial class ChatCompletionRequestTools
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}