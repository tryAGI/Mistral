
#nullable enable

namespace Mistral
{
    /// <summary>
    /// 
    /// </summary>
    public enum TranscriptionStreamEventsDataDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        TranscriptionDone,
        /// <summary>
        /// 
        /// </summary>
        TranscriptionLanguage,
        /// <summary>
        /// 
        /// </summary>
        TranscriptionSegment,
        /// <summary>
        /// 
        /// </summary>
        TranscriptionTextDelta,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TranscriptionStreamEventsDataDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TranscriptionStreamEventsDataDiscriminatorType value)
        {
            return value switch
            {
                TranscriptionStreamEventsDataDiscriminatorType.TranscriptionDone => "transcription.done",
                TranscriptionStreamEventsDataDiscriminatorType.TranscriptionLanguage => "transcription.language",
                TranscriptionStreamEventsDataDiscriminatorType.TranscriptionSegment => "transcription.segment",
                TranscriptionStreamEventsDataDiscriminatorType.TranscriptionTextDelta => "transcription.text.delta",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TranscriptionStreamEventsDataDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "transcription.done" => TranscriptionStreamEventsDataDiscriminatorType.TranscriptionDone,
                "transcription.language" => TranscriptionStreamEventsDataDiscriminatorType.TranscriptionLanguage,
                "transcription.segment" => TranscriptionStreamEventsDataDiscriminatorType.TranscriptionSegment,
                "transcription.text.delta" => TranscriptionStreamEventsDataDiscriminatorType.TranscriptionTextDelta,
                _ => null,
            };
        }
    }
}