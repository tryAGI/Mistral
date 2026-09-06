
#nullable enable

namespace Mistral
{
    /// <summary>
    ///
    /// </summary>
    public enum OCRRequestConfidenceScoresGranularity
    {
        /// <summary>
        ///
        /// </summary>
        Page,
        /// <summary>
        ///
        /// </summary>
        Word,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OCRRequestConfidenceScoresGranularityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OCRRequestConfidenceScoresGranularity value)
        {
            return value switch
            {
                OCRRequestConfidenceScoresGranularity.Page => "page",
                OCRRequestConfidenceScoresGranularity.Word => "word",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OCRRequestConfidenceScoresGranularity? ToEnum(string value)
        {
            return value switch
            {
                "page" => OCRRequestConfidenceScoresGranularity.Page,
                "word" => OCRRequestConfidenceScoresGranularity.Word,
                _ => null,
            };
        }
    }
}