
#nullable enable

namespace Mistral
{
    /// <summary>
    ///
    /// </summary>
    public enum OCRRequestTableFormat
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
    public static class OCRRequestTableFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OCRRequestTableFormat value)
        {
            return value switch
            {
                OCRRequestTableFormat.Html => "html",
                OCRRequestTableFormat.Markdown => "markdown",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OCRRequestTableFormat? ToEnum(string value)
        {
            return value switch
            {
                "html" => OCRRequestTableFormat.Html,
                "markdown" => OCRRequestTableFormat.Markdown,
                _ => null,
            };
        }
    }
}