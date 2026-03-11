
#nullable enable

namespace Mistral
{
    /// <summary>
    /// ToolChoice is either a ToolChoiceEnum or a ToolChoice
    /// </summary>
    public sealed partial class ToolChoice2
    {
        /// <summary>
        /// Default Value: function
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Mistral.JsonConverters.ToolTypesJsonConverter))]
        public global::Mistral.ToolTypes? Type { get; set; }

        /// <summary>
        /// this restriction of `Function` is used to select a specific function to call
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("function")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Mistral.FunctionName Function { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolChoice2" /> class.
        /// </summary>
        /// <param name="type">
        /// Default Value: function
        /// </param>
        /// <param name="function">
        /// this restriction of `Function` is used to select a specific function to call
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ToolChoice2(
            global::Mistral.FunctionName function,
            global::Mistral.ToolTypes? type)
        {
            this.Function = function ?? throw new global::System.ArgumentNullException(nameof(function));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolChoice2" /> class.
        /// </summary>
        public ToolChoice2()
        {
        }
    }
}