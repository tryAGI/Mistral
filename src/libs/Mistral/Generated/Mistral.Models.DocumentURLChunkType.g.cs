
#nullable enable

namespace Mistral
{
    /// <summary>
    /// Default Value: document_url
    /// </summary>
    public enum DocumentURLChunkType
    {
        /// <summary>
        /// 
        /// </summary>
        DocumentUrl,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DocumentURLChunkTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DocumentURLChunkType value)
        {
            return value switch
            {
                DocumentURLChunkType.DocumentUrl => "document_url",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DocumentURLChunkType? ToEnum(string value)
        {
            return value switch
            {
                "document_url" => DocumentURLChunkType.DocumentUrl,
                _ => null,
            };
        }
    }
}