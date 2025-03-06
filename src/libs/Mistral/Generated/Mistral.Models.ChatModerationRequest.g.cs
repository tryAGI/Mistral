
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Mistral
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatModerationRequest
    {
        /// <summary>
        /// Chat to classify
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Mistral.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::Mistral.InputVariant1Item>, global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::Mistral.InputVariant2ItemItem>>>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Mistral.AnyOf<global::System.Collections.Generic.IList<global::Mistral.InputVariant1Item>, global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::Mistral.InputVariant2ItemItem>>> Input { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("truncate_for_context_length")]
        public bool? TruncateForContextLength { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatModerationRequest" /> class.
        /// </summary>
        /// <param name="input">
        /// Chat to classify
        /// </param>
        /// <param name="model"></param>
        /// <param name="truncateForContextLength">
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatModerationRequest(
            global::Mistral.AnyOf<global::System.Collections.Generic.IList<global::Mistral.InputVariant1Item>, global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::Mistral.InputVariant2ItemItem>>> input,
            string model,
            bool? truncateForContextLength)
        {
            this.Input = input;
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.TruncateForContextLength = truncateForContextLength;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatModerationRequest" /> class.
        /// </summary>
        public ChatModerationRequest()
        {
        }
    }
}