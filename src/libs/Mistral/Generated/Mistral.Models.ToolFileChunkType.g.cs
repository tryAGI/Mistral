
#nullable enable

namespace Mistral
{
    /// <summary>
    /// Default Value: tool_file
    /// </summary>
    public enum ToolFileChunkType
    {
        /// <summary>
        /// 
        /// </summary>
        ToolFile,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ToolFileChunkTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ToolFileChunkType value)
        {
            return value switch
            {
                ToolFileChunkType.ToolFile => "tool_file",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ToolFileChunkType? ToEnum(string value)
        {
            return value switch
            {
                "tool_file" => ToolFileChunkType.ToolFile,
                _ => null,
            };
        }
    }
}