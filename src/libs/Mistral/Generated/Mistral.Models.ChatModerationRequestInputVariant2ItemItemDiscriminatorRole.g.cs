
#nullable enable

namespace Mistral
{
    /// <summary>
    /// 
    /// </summary>
    public enum ChatModerationRequestInputVariant2ItemItemDiscriminatorRole
    {
        /// <summary>
        /// 
        /// </summary>
        Assistant,
        /// <summary>
        /// 
        /// </summary>
        System,
        /// <summary>
        /// 
        /// </summary>
        Tool,
        /// <summary>
        /// 
        /// </summary>
        User,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatModerationRequestInputVariant2ItemItemDiscriminatorRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatModerationRequestInputVariant2ItemItemDiscriminatorRole value)
        {
            return value switch
            {
                ChatModerationRequestInputVariant2ItemItemDiscriminatorRole.Assistant => "assistant",
                ChatModerationRequestInputVariant2ItemItemDiscriminatorRole.System => "system",
                ChatModerationRequestInputVariant2ItemItemDiscriminatorRole.Tool => "tool",
                ChatModerationRequestInputVariant2ItemItemDiscriminatorRole.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatModerationRequestInputVariant2ItemItemDiscriminatorRole? ToEnum(string value)
        {
            return value switch
            {
                "assistant" => ChatModerationRequestInputVariant2ItemItemDiscriminatorRole.Assistant,
                "system" => ChatModerationRequestInputVariant2ItemItemDiscriminatorRole.System,
                "tool" => ChatModerationRequestInputVariant2ItemItemDiscriminatorRole.Tool,
                "user" => ChatModerationRequestInputVariant2ItemItemDiscriminatorRole.User,
                _ => null,
            };
        }
    }
}