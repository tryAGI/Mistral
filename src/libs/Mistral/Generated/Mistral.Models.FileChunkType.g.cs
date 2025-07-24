
#nullable enable

namespace Mistral
{
    /// <summary>
    /// Default Value: file
    /// </summary>
    public enum FileChunkType
    {
        /// <summary>
        /// 
        /// </summary>
        File,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FileChunkTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FileChunkType value)
        {
            return value switch
            {
                FileChunkType.File => "file",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FileChunkType? ToEnum(string value)
        {
            return value switch
            {
                "file" => FileChunkType.File,
                _ => null,
            };
        }
    }
}