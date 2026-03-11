
#nullable enable

namespace Mistral
{
    /// <summary>
    /// Default Value: server
    /// </summary>
    public enum ConversationAppendRequestBaseHandoffExecution
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
    public static class ConversationAppendRequestBaseHandoffExecutionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConversationAppendRequestBaseHandoffExecution value)
        {
            return value switch
            {
                ConversationAppendRequestBaseHandoffExecution.Client => "client",
                ConversationAppendRequestBaseHandoffExecution.Server => "server",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConversationAppendRequestBaseHandoffExecution? ToEnum(string value)
        {
            return value switch
            {
                "client" => ConversationAppendRequestBaseHandoffExecution.Client,
                "server" => ConversationAppendRequestBaseHandoffExecution.Server,
                _ => null,
            };
        }
    }
}