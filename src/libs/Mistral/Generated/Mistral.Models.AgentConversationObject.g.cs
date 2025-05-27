
#nullable enable

namespace Mistral
{
    /// <summary>
    /// Default Value: conversation
    /// </summary>
    public enum AgentConversationObject
    {
        /// <summary>
        /// 
        /// </summary>
        Conversation,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentConversationObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentConversationObject value)
        {
            return value switch
            {
                AgentConversationObject.Conversation => "conversation",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentConversationObject? ToEnum(string value)
        {
            return value switch
            {
                "conversation" => AgentConversationObject.Conversation,
                _ => null,
            };
        }
    }
}