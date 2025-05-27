
#nullable enable

namespace Mistral
{
    /// <summary>
    /// Default Value: message.output
    /// </summary>
    public enum MessageOutputEntryType
    {
        /// <summary>
        /// 
        /// </summary>
        MessageOutput,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MessageOutputEntryTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MessageOutputEntryType value)
        {
            return value switch
            {
                MessageOutputEntryType.MessageOutput => "message.output",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MessageOutputEntryType? ToEnum(string value)
        {
            return value switch
            {
                "message.output" => MessageOutputEntryType.MessageOutput,
                _ => null,
            };
        }
    }
}