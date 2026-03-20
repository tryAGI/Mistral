
#nullable enable

namespace Mistral
{
    /// <summary>
    /// Controls the reasoning effort level for reasoning models. "high" enables comprehensive reasoning traces, "none" disables reasoning effort.
    /// </summary>
    public enum AgentsCompletionRequestReasoningEffort
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
    public static class AgentsCompletionRequestReasoningEffortExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentsCompletionRequestReasoningEffort value)
        {
            return value switch
            {
                AgentsCompletionRequestReasoningEffort.High => "high",
                AgentsCompletionRequestReasoningEffort.None => "none",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentsCompletionRequestReasoningEffort? ToEnum(string value)
        {
            return value switch
            {
                "high" => AgentsCompletionRequestReasoningEffort.High,
                "none" => AgentsCompletionRequestReasoningEffort.None,
                _ => null,
            };
        }
    }
}