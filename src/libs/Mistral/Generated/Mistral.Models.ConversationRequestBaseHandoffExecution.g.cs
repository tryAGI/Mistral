
#nullable enable

namespace Mistral
{
    /// <summary>
    /// 
    /// </summary>
    public enum ConversationRequestBaseHandoffExecution
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
    public static class ConversationRequestBaseHandoffExecutionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConversationRequestBaseHandoffExecution value)
        {
            return value switch
            {
                ConversationRequestBaseHandoffExecution.Client => "client",
                ConversationRequestBaseHandoffExecution.Server => "server",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConversationRequestBaseHandoffExecution? ToEnum(string value)
        {
            return value switch
            {
                "client" => ConversationRequestBaseHandoffExecution.Client,
                "server" => ConversationRequestBaseHandoffExecution.Server,
                _ => null,
            };
        }
    }
}