
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
        Block,
        /// <summary>
        /// 
        /// </summary>
        None,
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
                ModerationLLMAction.Block => "block",
                ModerationLLMAction.None => "none",
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
                "block" => ModerationLLMAction.Block,
                "none" => ModerationLLMAction.None,
                _ => null,
            };
        }
    }
}