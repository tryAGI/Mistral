
#nullable enable

namespace Mistral
{
    /// <summary>
    /// 
    /// </summary>
    public enum ModerationLLMV1Action
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
    public static class ModerationLLMV1ActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ModerationLLMV1Action value)
        {
            return value switch
            {
                ModerationLLMV1Action.None => "none",
                ModerationLLMV1Action.Block => "block",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ModerationLLMV1Action? ToEnum(string value)
        {
            return value switch
            {
                "none" => ModerationLLMV1Action.None,
                "block" => ModerationLLMV1Action.Block,
                _ => null,
            };
        }
    }
}