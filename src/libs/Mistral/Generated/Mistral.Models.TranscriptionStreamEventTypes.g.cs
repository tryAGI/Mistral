
#nullable enable

namespace Mistral
{
    /// <summary>
    /// 
    /// </summary>
    public enum TranscriptionStreamEventTypes
    {
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
        /// <summary>
        /// 
        /// </summary>
        TranscriptionDone,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TranscriptionStreamEventTypesExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TranscriptionStreamEventTypes value)
        {
            return value switch
            {
                TranscriptionStreamEventTypes.TranscriptionLanguage => "transcription.language",
                TranscriptionStreamEventTypes.TranscriptionSegment => "transcription.segment",
                TranscriptionStreamEventTypes.TranscriptionTextDelta => "transcription.text.delta",
                TranscriptionStreamEventTypes.TranscriptionDone => "transcription.done",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TranscriptionStreamEventTypes? ToEnum(string value)
        {
            return value switch
            {
                "transcription.language" => TranscriptionStreamEventTypes.TranscriptionLanguage,
                "transcription.segment" => TranscriptionStreamEventTypes.TranscriptionSegment,
                "transcription.text.delta" => TranscriptionStreamEventTypes.TranscriptionTextDelta,
                "transcription.done" => TranscriptionStreamEventTypes.TranscriptionDone,
                _ => null,
            };
        }
    }
}