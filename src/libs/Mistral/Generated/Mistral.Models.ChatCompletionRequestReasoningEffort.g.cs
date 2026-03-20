
#nullable enable

namespace Mistral
{
    /// <summary>
    /// Controls the reasoning effort level for reasoning models. "high" enables comprehensive reasoning traces, "none" disables reasoning effort.
    /// </summary>
    public enum ChatCompletionRequestReasoningEffort
    {
        /// <summary>
        /// 
        /// </summary>
        High,
        /// <summary>
        /// 
        /// </summary>
        None,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatCompletionRequestReasoningEffortExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatCompletionRequestReasoningEffort value)
        {
            return value switch
            {
                ChatCompletionRequestReasoningEffort.High => "high",
                ChatCompletionRequestReasoningEffort.None => "none",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatCompletionRequestReasoningEffort? ToEnum(string value)
        {
            return value switch
            {
                "high" => ChatCompletionRequestReasoningEffort.High,
                "none" => ChatCompletionRequestReasoningEffort.None,
                _ => null,
            };
        }
    }
}