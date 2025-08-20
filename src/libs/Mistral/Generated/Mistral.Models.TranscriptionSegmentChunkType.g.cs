
#nullable enable

namespace Mistral
{
    /// <summary>
    /// Default Value: transcription_segment
    /// </summary>
    public enum TranscriptionSegmentChunkType
    {
        /// <summary>
        /// 
        /// </summary>
        TranscriptionSegment,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TranscriptionSegmentChunkTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TranscriptionSegmentChunkType value)
        {
            return value switch
            {
                TranscriptionSegmentChunkType.TranscriptionSegment => "transcription_segment",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TranscriptionSegmentChunkType? ToEnum(string value)
        {
            return value switch
            {
                "transcription_segment" => TranscriptionSegmentChunkType.TranscriptionSegment,
                _ => null,
            };
        }
    }
}