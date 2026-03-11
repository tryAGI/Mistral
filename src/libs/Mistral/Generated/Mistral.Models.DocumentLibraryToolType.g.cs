
#nullable enable

namespace Mistral
{
    /// <summary>
    /// Default Value: document_library
    /// </summary>
    public enum DocumentLibraryToolType
    {
        /// <summary>
        /// 
        /// </summary>
        DocumentLibrary,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DocumentLibraryToolTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DocumentLibraryToolType value)
        {
            return value switch
            {
                DocumentLibraryToolType.DocumentLibrary => "document_library",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DocumentLibraryToolType? ToEnum(string value)
        {
            return value switch
            {
                "document_library" => DocumentLibraryToolType.DocumentLibrary,
                _ => null,
            };
        }
    }
}