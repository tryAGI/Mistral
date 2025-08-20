
#nullable enable

namespace Mistral
{
    /// <summary>
    /// Default Value: transcription.done
    /// </summary>
    public enum TranscriptionStreamDoneType
    {
        /// <summary>
        /// 
        /// </summary>
        TranscriptionDone,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TranscriptionStreamDoneTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TranscriptionStreamDoneType value)
        {
            return value switch
            {
                TranscriptionStreamDoneType.TranscriptionDone => "transcription.done",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TranscriptionStreamDoneType? ToEnum(string value)
        {
            return value switch
            {
                "transcription.done" => TranscriptionStreamDoneType.TranscriptionDone,
                _ => null,
            };
        }
    }
}