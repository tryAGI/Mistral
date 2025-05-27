
#nullable enable

namespace Mistral
{
    /// <summary>
    /// Default Value: conversation.history
    /// </summary>
    public enum ConversationHistoryObject
    {
        /// <summary>
        /// 
        /// </summary>
        ConversationHistory,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ConversationHistoryObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConversationHistoryObject value)
        {
            return value switch
            {
                ConversationHistoryObject.ConversationHistory => "conversation.history",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConversationHistoryObject? ToEnum(string value)
        {
            return value switch
            {
                "conversation.history" => ConversationHistoryObject.ConversationHistory,
                _ => null,
            };
        }
    }
}