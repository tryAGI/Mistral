
#nullable enable

namespace Mistral
{
    /// <summary>
    /// Default Value: message.output.delta
    /// </summary>
    public enum MessageOutputEventType
    {
        /// <summary>
        /// 
        /// </summary>
        MessageOutputDelta,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MessageOutputEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MessageOutputEventType value)
        {
            return value switch
            {
                MessageOutputEventType.MessageOutputDelta => "message.output.delta",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MessageOutputEventType? ToEnum(string value)
        {
            return value switch
            {
                "message.output.delta" => MessageOutputEventType.MessageOutputDelta,
                _ => null,
            };
        }
    }
}