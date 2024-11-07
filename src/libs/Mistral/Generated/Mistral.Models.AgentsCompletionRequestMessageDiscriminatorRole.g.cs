
#nullable enable

namespace Mistral
{
    /// <summary>
    /// 
    /// </summary>
    public enum AgentsCompletionRequestMessageDiscriminatorRole
    {
        /// <summary>
        /// 
        /// </summary>
        Assistant,
        /// <summary>
        /// 
        /// </summary>
        System,
        /// <summary>
        /// 
        /// </summary>
        Tool,
        /// <summary>
        /// 
        /// </summary>
        User,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentsCompletionRequestMessageDiscriminatorRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentsCompletionRequestMessageDiscriminatorRole value)
        {
            return value switch
            {
                AgentsCompletionRequestMessageDiscriminatorRole.Assistant => "assistant",
                AgentsCompletionRequestMessageDiscriminatorRole.System => "system",
                AgentsCompletionRequestMessageDiscriminatorRole.Tool => "tool",
                AgentsCompletionRequestMessageDiscriminatorRole.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentsCompletionRequestMessageDiscriminatorRole? ToEnum(string value)
        {
            return value switch
            {
                "assistant" => AgentsCompletionRequestMessageDiscriminatorRole.Assistant,
                "system" => AgentsCompletionRequestMessageDiscriminatorRole.System,
                "tool" => AgentsCompletionRequestMessageDiscriminatorRole.Tool,
                "user" => AgentsCompletionRequestMessageDiscriminatorRole.User,
                _ => null,
            };
        }
    }
}