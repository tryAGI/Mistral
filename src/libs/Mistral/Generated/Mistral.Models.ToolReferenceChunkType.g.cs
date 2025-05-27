
#nullable enable

namespace Mistral
{
    /// <summary>
    /// Default Value: tool_reference
    /// </summary>
    public enum ToolReferenceChunkType
    {
        /// <summary>
        /// 
        /// </summary>
        ToolReference,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ToolReferenceChunkTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ToolReferenceChunkType value)
        {
            return value switch
            {
                ToolReferenceChunkType.ToolReference => "tool_reference",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ToolReferenceChunkType? ToEnum(string value)
        {
            return value switch
            {
                "tool_reference" => ToolReferenceChunkType.ToolReference,
                _ => null,
            };
        }
    }
}