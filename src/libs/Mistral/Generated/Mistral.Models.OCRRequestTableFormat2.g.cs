
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
        Html,
        /// <summary>
        /// 
        /// </summary>
        Markdown,
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
                OCRRequestTableFormat2.Html => "html",
                OCRRequestTableFormat2.Markdown => "markdown",
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
                "html" => OCRRequestTableFormat2.Html,
                "markdown" => OCRRequestTableFormat2.Markdown,
                _ => null,
            };
        }
    }
}