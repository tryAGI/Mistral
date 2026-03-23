
#nullable enable

namespace Mistral
{
    /// <summary>
    /// Format of the table
    /// </summary>
    public enum OCRTableObjectFormat
    {
        /// <summary>
        /// 
        /// </summary>
        Html,
        /// <summary>
        /// 
        /// </summary>
        Markdown,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OCRTableObjectFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OCRTableObjectFormat value)
        {
            return value switch
            {
                OCRTableObjectFormat.Html => "html",
                OCRTableObjectFormat.Markdown => "markdown",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OCRTableObjectFormat? ToEnum(string value)
        {
            return value switch
            {
                "html" => OCRTableObjectFormat.Html,
                "markdown" => OCRTableObjectFormat.Markdown,
                _ => null,
            };
        }
    }
}