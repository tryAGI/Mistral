
#nullable enable

namespace Mistral
{
    /// <summary>
    /// Default Value: image_url
    /// </summary>
    public enum ImageURLChunkType
    {
        /// <summary>
        /// 
        /// </summary>
        ImageUrl,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ImageURLChunkTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ImageURLChunkType value)
        {
            return value switch
            {
                ImageURLChunkType.ImageUrl => "image_url",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ImageURLChunkType? ToEnum(string value)
        {
            return value switch
            {
                "image_url" => ImageURLChunkType.ImageUrl,
                _ => null,
            };
        }
    }
}