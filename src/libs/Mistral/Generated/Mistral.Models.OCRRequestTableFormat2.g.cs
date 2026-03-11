
#nullable enable

namespace Mistral
{
    /// <summary>
    /// 
    /// </summary>
    public enum OCRRequestTableFormat2
    {
        /// <summary>
        /// 
        /// </summary>
        Markdown,
        /// <summary>
        /// 
        /// </summary>
        Html,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OCRRequestTableFormat2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OCRRequestTableFormat2 value)
        {
            return value switch
            {
                OCRRequestTableFormat2.Markdown => "markdown",
                OCRRequestTableFormat2.Html => "html",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OCRRequestTableFormat2? ToEnum(string value)
        {
            return value switch
            {
                "markdown" => OCRRequestTableFormat2.Markdown,
                "html" => OCRRequestTableFormat2.Html,
                _ => null,
            };
        }
    }
}