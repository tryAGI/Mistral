
#nullable enable

namespace Mistral
{
    /// <summary>
    /// Default Value: message.input
    /// </summary>
    public enum MessageInputEntryType
    {
        /// <summary>
        /// 
        /// </summary>
        MessageInput,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MessageInputEntryTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MessageInputEntryType value)
        {
            return value switch
            {
                MessageInputEntryType.MessageInput => "message.input",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MessageInputEntryType? ToEnum(string value)
        {
            return value switch
            {
                "message.input" => MessageInputEntryType.MessageInput,
                _ => null,
            };
        }
    }
}