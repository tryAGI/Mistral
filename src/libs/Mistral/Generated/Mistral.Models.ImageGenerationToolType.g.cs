
#nullable enable

namespace Mistral
{
    /// <summary>
    /// Default Value: image_generation
    /// </summary>
    public enum ImageGenerationToolType
    {
        /// <summary>
        /// 
        /// </summary>
        ImageGeneration,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ImageGenerationToolTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ImageGenerationToolType value)
        {
            return value switch
            {
                ImageGenerationToolType.ImageGeneration => "image_generation",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ImageGenerationToolType? ToEnum(string value)
        {
            return value switch
            {
                "image_generation" => ImageGenerationToolType.ImageGeneration,
                _ => null,
            };
        }
    }
}