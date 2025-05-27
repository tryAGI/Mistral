
#nullable enable

namespace Mistral
{
    /// <summary>
    /// Default Value: assistant
    /// </summary>
    public enum MessageOutputEntryRole
    {
        /// <summary>
        /// 
        /// </summary>
        Assistant,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MessageOutputEntryRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MessageOutputEntryRole value)
        {
            return value switch
            {
                MessageOutputEntryRole.Assistant => "assistant",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MessageOutputEntryRole? ToEnum(string value)
        {
            return value switch
            {
                "assistant" => MessageOutputEntryRole.Assistant,
                _ => null,
            };
        }
    }
}