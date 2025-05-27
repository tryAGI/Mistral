
#nullable enable

namespace Mistral
{
    /// <summary>
    /// Default Value: conversation.response
    /// </summary>
    public enum ConversationResponseObject
    {
        /// <summary>
        /// 
        /// </summary>
        ConversationResponse,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ConversationResponseObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConversationResponseObject value)
        {
            return value switch
            {
                ConversationResponseObject.ConversationResponse => "conversation.response",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConversationResponseObject? ToEnum(string value)
        {
            return value switch
            {
                "conversation.response" => ConversationResponseObject.ConversationResponse,
                _ => null,
            };
        }
    }
}