
#nullable enable

namespace Mistral
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatCompletionFields
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("field_definitions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Mistral.BaseFieldDefinition> FieldDefinitions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("field_groups")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Mistral.FieldGroup> FieldGroups { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionFields" /> class.
        /// </summary>
        /// <param name="fieldDefinitions"></param>
        /// <param name="fieldGroups"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatCompletionFields(
            global::System.Collections.Generic.IList<global::Mistral.BaseFieldDefinition> fieldDefinitions,
            global::System.Collections.Generic.IList<global::Mistral.FieldGroup> fieldGroups)
        {
            this.FieldDefinitions = fieldDefinitions ?? throw new global::System.ArgumentNullException(nameof(fieldDefinitions));
            this.FieldGroups = fieldGroups ?? throw new global::System.ArgumentNullException(nameof(fieldGroups));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionFields" /> class.
        /// </summary>
        public ChatCompletionFields()
        {
        }
    }
}