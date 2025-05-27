
#nullable enable

namespace Mistral
{
    /// <summary>
    /// Default Value: conversation.response.started
    /// </summary>
    public enum ResponseStartedEventType
    {
        /// <summary>
        /// 
        /// </summary>
        ConversationResponseStarted,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponseStartedEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseStartedEventType value)
        {
            return value switch
            {
                ResponseStartedEventType.ConversationResponseStarted => "conversation.response.started",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseStartedEventType? ToEnum(string value)
        {
            return value switch
            {
                "conversation.response.started" => ResponseStartedEventType.ConversationResponseStarted,
                _ => null,
            };
        }
    }
}