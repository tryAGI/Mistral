
#nullable enable

namespace Mistral
{
    /// <summary>
    /// 
    /// </summary>
    public enum ContentChunkDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        DocumentUrl,
        /// <summary>
        /// 
        /// </summary>
        File,
        /// <summary>
        /// 
        /// </summary>
        ImageUrl,
        /// <summary>
        /// 
        /// </summary>
        InputAudio,
        /// <summary>
        /// 
        /// </summary>
        Reference,
        /// <summary>
        /// 
        /// </summary>
        Text,
        /// <summary>
        /// 
        /// </summary>
        Thinking,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ContentChunkDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ContentChunkDiscriminatorType value)
        {
            return value switch
            {
                ContentChunkDiscriminatorType.DocumentUrl => "document_url",
                ContentChunkDiscriminatorType.File => "file",
                ContentChunkDiscriminatorType.ImageUrl => "image_url",
                ContentChunkDiscriminatorType.InputAudio => "input_audio",
                ContentChunkDiscriminatorType.Reference => "reference",
                ContentChunkDiscriminatorType.Text => "text",
                ContentChunkDiscriminatorType.Thinking => "thinking",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ContentChunkDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "document_url" => ContentChunkDiscriminatorType.DocumentUrl,
                "file" => ContentChunkDiscriminatorType.File,
                "image_url" => ContentChunkDiscriminatorType.ImageUrl,
                "input_audio" => ContentChunkDiscriminatorType.InputAudio,
                "reference" => ContentChunkDiscriminatorType.Reference,
                "text" => ContentChunkDiscriminatorType.Text,
                "thinking" => ContentChunkDiscriminatorType.Thinking,
                _ => null,
            };
        }
    }
}