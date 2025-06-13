
#nullable enable

namespace Mistral
{
    /// <summary>
    /// 
    /// </summary>
    public enum MistralPromptMode
    {
        /// <summary>
        /// 
        /// </summary>
        Reasoning,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MistralPromptModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MistralPromptMode value)
        {
            return value switch
            {
                MistralPromptMode.Reasoning => "reasoning",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MistralPromptMode? ToEnum(string value)
        {
            return value switch
            {
                "reasoning" => MistralPromptMode.Reasoning,
                _ => null,
            };
        }
    }
}