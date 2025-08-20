
#nullable enable

namespace Mistral
{
    /// <summary>
    /// 
    /// </summary>
    public enum TimestampGranularity
    {
        /// <summary>
        /// 
        /// </summary>
        Segment,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TimestampGranularityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TimestampGranularity value)
        {
            return value switch
            {
                TimestampGranularity.Segment => "segment",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TimestampGranularity? ToEnum(string value)
        {
            return value switch
            {
                "segment" => TimestampGranularity.Segment,
                _ => null,
            };
        }
    }
}