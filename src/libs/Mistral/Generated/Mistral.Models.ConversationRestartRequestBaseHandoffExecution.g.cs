
#nullable enable

namespace Mistral
{
    /// <summary>
    /// Default Value: server
    /// </summary>
    public enum ConversationRestartRequestBaseHandoffExecution
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
    public static class ConversationRestartRequestBaseHandoffExecutionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConversationRestartRequestBaseHandoffExecution value)
        {
            return value switch
            {
                ConversationRestartRequestBaseHandoffExecution.Client => "client",
                ConversationRestartRequestBaseHandoffExecution.Server => "server",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConversationRestartRequestBaseHandoffExecution? ToEnum(string value)
        {
            return value switch
            {
                "client" => ConversationRestartRequestBaseHandoffExecution.Client,
                "server" => ConversationRestartRequestBaseHandoffExecution.Server,
                _ => null,
            };
        }
    }
}