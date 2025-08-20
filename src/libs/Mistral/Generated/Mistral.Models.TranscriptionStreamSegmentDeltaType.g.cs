
#nullable enable

namespace Mistral
{
    /// <summary>
    /// Default Value: transcription.segment
    /// </summary>
    public enum TranscriptionStreamSegmentDeltaType
    {
        /// <summary>
        /// 
        /// </summary>
        TranscriptionSegment,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TranscriptionStreamSegmentDeltaTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TranscriptionStreamSegmentDeltaType value)
        {
            return value switch
            {
                TranscriptionStreamSegmentDeltaType.TranscriptionSegment => "transcription.segment",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TranscriptionStreamSegmentDeltaType? ToEnum(string value)
        {
            return value switch
            {
                "transcription.segment" => TranscriptionStreamSegmentDeltaType.TranscriptionSegment,
                _ => null,
            };
        }
    }
}