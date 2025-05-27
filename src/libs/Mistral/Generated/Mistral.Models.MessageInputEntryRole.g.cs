
#nullable enable

namespace Mistral
{
    /// <summary>
    /// 
    /// </summary>
    public enum MessageInputEntryRole
    {
        /// <summary>
        /// 
        /// </summary>
        Assistant,
        /// <summary>
        /// 
        /// </summary>
        User,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MessageInputEntryRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MessageInputEntryRole value)
        {
            return value switch
            {
                MessageInputEntryRole.Assistant => "assistant",
                MessageInputEntryRole.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MessageInputEntryRole? ToEnum(string value)
        {
            return value switch
            {
                "assistant" => MessageInputEntryRole.Assistant,
                "user" => MessageInputEntryRole.User,
                _ => null,
            };
        }
    }
}