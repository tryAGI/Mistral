
#nullable enable

namespace Mistral
{
    /// <summary>
    /// Default Value: conversation.response.error
    /// </summary>
    public enum ResponseErrorEventType
    {
        /// <summary>
        /// 
        /// </summary>
        ConversationResponseError,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponseErrorEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseErrorEventType value)
        {
            return value switch
            {
                ResponseErrorEventType.ConversationResponseError => "conversation.response.error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseErrorEventType? ToEnum(string value)
        {
            return value switch
            {
                "conversation.response.error" => ResponseErrorEventType.ConversationResponseError,
                _ => null,
            };
        }
    }
}