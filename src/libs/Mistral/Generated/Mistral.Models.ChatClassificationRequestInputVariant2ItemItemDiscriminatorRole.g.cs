
#nullable enable

namespace Mistral
{
    /// <summary>
    /// 
    /// </summary>
    public enum ChatClassificationRequestInputVariant2ItemItemDiscriminatorRole
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
    public static class ChatClassificationRequestInputVariant2ItemItemDiscriminatorRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatClassificationRequestInputVariant2ItemItemDiscriminatorRole value)
        {
            return value switch
            {
                ChatClassificationRequestInputVariant2ItemItemDiscriminatorRole.Assistant => "assistant",
                ChatClassificationRequestInputVariant2ItemItemDiscriminatorRole.System => "system",
                ChatClassificationRequestInputVariant2ItemItemDiscriminatorRole.Tool => "tool",
                ChatClassificationRequestInputVariant2ItemItemDiscriminatorRole.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatClassificationRequestInputVariant2ItemItemDiscriminatorRole? ToEnum(string value)
        {
            return value switch
            {
                "assistant" => ChatClassificationRequestInputVariant2ItemItemDiscriminatorRole.Assistant,
                "system" => ChatClassificationRequestInputVariant2ItemItemDiscriminatorRole.System,
                "tool" => ChatClassificationRequestInputVariant2ItemItemDiscriminatorRole.Tool,
                "user" => ChatClassificationRequestInputVariant2ItemItemDiscriminatorRole.User,
                _ => null,
            };
        }
    }
}