
#nullable enable

namespace Mistral
{
    /// <summary>
    ///
    /// </summary>
    public enum CompletionArgsReasoningEffort
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
    public static class CompletionArgsReasoningEffortExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CompletionArgsReasoningEffort value)
        {
            return value switch
            {
                CompletionArgsReasoningEffort.High => "high",
                CompletionArgsReasoningEffort.None => "none",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CompletionArgsReasoningEffort? ToEnum(string value)
        {
            return value switch
            {
                "high" => CompletionArgsReasoningEffort.High,
                "none" => CompletionArgsReasoningEffort.None,
                _ => null,
            };
        }
    }
}