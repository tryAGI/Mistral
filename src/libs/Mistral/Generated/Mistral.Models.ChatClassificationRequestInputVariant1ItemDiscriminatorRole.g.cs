
#nullable enable

namespace Mistral
{
    /// <summary>
    /// 
    /// </summary>
    public enum ChatClassificationRequestInputVariant1ItemDiscriminatorRole
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
    public static class ChatClassificationRequestInputVariant1ItemDiscriminatorRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatClassificationRequestInputVariant1ItemDiscriminatorRole value)
        {
            return value switch
            {
                ChatClassificationRequestInputVariant1ItemDiscriminatorRole.Assistant => "assistant",
                ChatClassificationRequestInputVariant1ItemDiscriminatorRole.System => "system",
                ChatClassificationRequestInputVariant1ItemDiscriminatorRole.Tool => "tool",
                ChatClassificationRequestInputVariant1ItemDiscriminatorRole.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatClassificationRequestInputVariant1ItemDiscriminatorRole? ToEnum(string value)
        {
            return value switch
            {
                "assistant" => ChatClassificationRequestInputVariant1ItemDiscriminatorRole.Assistant,
                "system" => ChatClassificationRequestInputVariant1ItemDiscriminatorRole.System,
                "tool" => ChatClassificationRequestInputVariant1ItemDiscriminatorRole.Tool,
                "user" => ChatClassificationRequestInputVariant1ItemDiscriminatorRole.User,
                _ => null,
            };
        }
    }
}