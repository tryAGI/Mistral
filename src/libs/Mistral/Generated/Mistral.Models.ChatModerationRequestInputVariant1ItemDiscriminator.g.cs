
#nullable enable

namespace Mistral
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatModerationRequestInputVariant1ItemDiscriminator
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Mistral.JsonConverters.ChatModerationRequestInputVariant1ItemDiscriminatorRoleJsonConverter))]
        public global::Mistral.ChatModerationRequestInputVariant1ItemDiscriminatorRole? Role { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatModerationRequestInputVariant1ItemDiscriminator" /> class.
        /// </summary>
        /// <param name="role"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatModerationRequestInputVariant1ItemDiscriminator(
            global::Mistral.ChatModerationRequestInputVariant1ItemDiscriminatorRole? role)
        {
            this.Role = role;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatModerationRequestInputVariant1ItemDiscriminator" /> class.
        /// </summary>
        public ChatModerationRequestInputVariant1ItemDiscriminator()
        {
        }
    }
}