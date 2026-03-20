
#nullable enable

namespace Mistral
{
    /// <summary>
    /// 
    /// </summary>
    public enum CompletionArgsReasoningEffort2
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
    public static class CompletionArgsReasoningEffort2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CompletionArgsReasoningEffort2 value)
        {
            return value switch
            {
                CompletionArgsReasoningEffort2.High => "high",
                CompletionArgsReasoningEffort2.None => "none",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CompletionArgsReasoningEffort2? ToEnum(string value)
        {
            return value switch
            {
                "high" => CompletionArgsReasoningEffort2.High,
                "none" => CompletionArgsReasoningEffort2.None,
                _ => null,
            };
        }
    }
}