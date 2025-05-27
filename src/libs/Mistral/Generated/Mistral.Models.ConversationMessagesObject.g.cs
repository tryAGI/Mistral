
#nullable enable

namespace Mistral
{
    /// <summary>
    /// Default Value: conversation.messages
    /// </summary>
    public enum ConversationMessagesObject
    {
        /// <summary>
        /// 
        /// </summary>
        ConversationMessages,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ConversationMessagesObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConversationMessagesObject value)
        {
            return value switch
            {
                ConversationMessagesObject.ConversationMessages => "conversation.messages",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConversationMessagesObject? ToEnum(string value)
        {
            return value switch
            {
                "conversation.messages" => ConversationMessagesObject.ConversationMessages,
                _ => null,
            };
        }
    }
}