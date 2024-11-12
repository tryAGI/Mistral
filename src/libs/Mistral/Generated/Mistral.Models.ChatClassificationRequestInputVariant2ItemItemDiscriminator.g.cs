
#nullable enable

namespace Mistral
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatClassificationRequestInputVariant2ItemItemDiscriminator
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Mistral.JsonConverters.ChatClassificationRequestInputVariant2ItemItemDiscriminatorRoleJsonConverter))]
        public global::Mistral.ChatClassificationRequestInputVariant2ItemItemDiscriminatorRole? Role { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatClassificationRequestInputVariant2ItemItemDiscriminator" /> class.
        /// </summary>
        /// <param name="role"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public ChatClassificationRequestInputVariant2ItemItemDiscriminator(
            global::Mistral.ChatClassificationRequestInputVariant2ItemItemDiscriminatorRole? role)
        {
            this.Role = role;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatClassificationRequestInputVariant2ItemItemDiscriminator" /> class.
        /// </summary>
        public ChatClassificationRequestInputVariant2ItemItemDiscriminator()
        {
        }
    }
}