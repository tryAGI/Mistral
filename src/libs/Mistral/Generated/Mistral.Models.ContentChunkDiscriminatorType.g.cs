
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
        ImageUrl,
        /// <summary>
        /// 
        /// </summary>
        DocumentUrl,
        /// <summary>
        /// 
        /// </summary>
        Text,
        /// <summary>
        /// 
        /// </summary>
        Reference,
        /// <summary>
        /// 
        /// </summary>
        File,
        /// <summary>
        /// 
        /// </summary>
        Thinking,
        /// <summary>
        /// 
        /// </summary>
        InputAudio,
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
                ContentChunkDiscriminatorType.ImageUrl => "image_url",
                ContentChunkDiscriminatorType.DocumentUrl => "document_url",
                ContentChunkDiscriminatorType.Text => "text",
                ContentChunkDiscriminatorType.Reference => "reference",
                ContentChunkDiscriminatorType.File => "file",
                ContentChunkDiscriminatorType.Thinking => "thinking",
                ContentChunkDiscriminatorType.InputAudio => "input_audio",
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
                "image_url" => ContentChunkDiscriminatorType.ImageUrl,
                "document_url" => ContentChunkDiscriminatorType.DocumentUrl,
                "text" => ContentChunkDiscriminatorType.Text,
                "reference" => ContentChunkDiscriminatorType.Reference,
                "file" => ContentChunkDiscriminatorType.File,
                "thinking" => ContentChunkDiscriminatorType.Thinking,
                "input_audio" => ContentChunkDiscriminatorType.InputAudio,
                _ => null,
            };
        }
    }
}