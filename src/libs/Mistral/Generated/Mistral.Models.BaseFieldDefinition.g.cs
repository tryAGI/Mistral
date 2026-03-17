
#nullable enable

namespace Mistral
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BaseFieldDefinition
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("label")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Label { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Mistral.JsonConverters.BaseFieldDefinitionTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Mistral.BaseFieldDefinitionType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("group")]
        public string? Group { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("supported_operators")]
        public global::System.Collections.Generic.IList<global::Mistral.BaseFieldDefinitionSupportedOperator> SupportedOperators { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseFieldDefinition" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="label"></param>
        /// <param name="type"></param>
        /// <param name="group"></param>
        /// <param name="supportedOperators">
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BaseFieldDefinition(
            string name,
            string label,
            global::Mistral.BaseFieldDefinitionType type,
            string? group,
            global::System.Collections.Generic.IList<global::Mistral.BaseFieldDefinitionSupportedOperator> supportedOperators = default!)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Label = label ?? throw new global::System.ArgumentNullException(nameof(label));
            this.Type = type;
            this.Group = group;
            this.SupportedOperators = supportedOperators;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseFieldDefinition" /> class.
        /// </summary>
        public BaseFieldDefinition()
        {
        }
    }
}