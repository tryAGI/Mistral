
#nullable enable

namespace Mistral
{
    /// <summary>
    /// Default Value: conversation.response.done
    /// </summary>
    public enum ResponseDoneEventType
    {
        /// <summary>
        /// 
        /// </summary>
        ConversationResponseDone,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponseDoneEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseDoneEventType value)
        {
            return value switch
            {
                ResponseDoneEventType.ConversationResponseDone => "conversation.response.done",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseDoneEventType? ToEnum(string value)
        {
            return value switch
            {
                "conversation.response.done" => ResponseDoneEventType.ConversationResponseDone,
                _ => null,
            };
        }
    }
}