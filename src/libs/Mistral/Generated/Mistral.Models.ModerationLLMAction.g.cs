
#nullable enable

namespace Mistral
{
    /// <summary>
    /// 
    /// </summary>
    public enum ModerationLLMAction
    {
        /// <summary>
        /// 
        /// </summary>
        None,
        /// <summary>
        /// 
        /// </summary>
        Block,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ModerationLLMActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ModerationLLMAction value)
        {
            return value switch
            {
                ModerationLLMAction.None => "none",
                ModerationLLMAction.Block => "block",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ModerationLLMAction? ToEnum(string value)
        {
            return value switch
            {
                "none" => ModerationLLMAction.None,
                "block" => ModerationLLMAction.Block,
                _ => null,
            };
        }
    }
}