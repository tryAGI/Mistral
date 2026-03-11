
#nullable enable

namespace Mistral
{
    /// <summary>
    /// 
    /// </summary>
    public enum ConversationRequestBaseHandoffExecution2
    {
        /// <summary>
        /// 
        /// </summary>
        Client,
        /// <summary>
        /// 
        /// </summary>
        Server,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ConversationRequestBaseHandoffExecution2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConversationRequestBaseHandoffExecution2 value)
        {
            return value switch
            {
                ConversationRequestBaseHandoffExecution2.Client => "client",
                ConversationRequestBaseHandoffExecution2.Server => "server",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConversationRequestBaseHandoffExecution2? ToEnum(string value)
        {
            return value switch
            {
                "client" => ConversationRequestBaseHandoffExecution2.Client,
                "server" => ConversationRequestBaseHandoffExecution2.Server,
                _ => null,
            };
        }
    }
}