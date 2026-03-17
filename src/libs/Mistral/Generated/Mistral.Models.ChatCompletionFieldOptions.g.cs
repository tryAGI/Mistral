
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Mistral
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatCompletionFieldOptions
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("options")]
        public global::System.Collections.Generic.IList<global::Mistral.AnyOf<string, bool?, object>>? Options { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionFieldOptions" /> class.
        /// </summary>
        /// <param name="options"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatCompletionFieldOptions(
            global::System.Collections.Generic.IList<global::Mistral.AnyOf<string, bool?, object>>? options)
        {
            this.Options = options;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionFieldOptions" /> class.
        /// </summary>
        public ChatCompletionFieldOptions()
        {
        }
    }
}