
#nullable enable

namespace Mistral
{
    /// <summary>
    /// 
    /// </summary>
    public enum ToolType
    {
        /// <summary>
        /// 
        /// </summary>
        Code,
        /// <summary>
        /// 
        /// </summary>
        Event,
        /// <summary>
        /// 
        /// </summary>
        Image,
        /// <summary>
        /// 
        /// </summary>
        Rag,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ToolTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ToolType value)
        {
            return value switch
            {
                ToolType.Code => "code",
                ToolType.Event => "event",
                ToolType.Image => "image",
                ToolType.Rag => "rag",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ToolType? ToEnum(string value)
        {
            return value switch
            {
                "code" => ToolType.Code,
                "event" => ToolType.Event,
                "image" => ToolType.Image,
                "rag" => ToolType.Rag,
                _ => null,
            };
        }
    }
}