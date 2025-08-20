
#nullable enable

namespace Mistral
{
    /// <summary>
    /// Default Value: thinking
    /// </summary>
    public enum ThinkChunkType
    {
        /// <summary>
        /// 
        /// </summary>
        Thinking,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ThinkChunkTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ThinkChunkType value)
        {
            return value switch
            {
                ThinkChunkType.Thinking => "thinking",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ThinkChunkType? ToEnum(string value)
        {
            return value switch
            {
                "thinking" => ThinkChunkType.Thinking,
                _ => null,
            };
        }
    }
}