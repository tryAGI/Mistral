
#nullable enable

namespace Mistral
{
    /// <summary>
    /// 
    /// </summary>
    public enum OCRRequestConfidenceScoresGranularity2
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
    public static class OCRRequestConfidenceScoresGranularity2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OCRRequestConfidenceScoresGranularity2 value)
        {
            return value switch
            {
                OCRRequestConfidenceScoresGranularity2.Page => "page",
                OCRRequestConfidenceScoresGranularity2.Word => "word",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OCRRequestConfidenceScoresGranularity2? ToEnum(string value)
        {
            return value switch
            {
                "page" => OCRRequestConfidenceScoresGranularity2.Page,
                "word" => OCRRequestConfidenceScoresGranularity2.Word,
                _ => null,
            };
        }
    }
}