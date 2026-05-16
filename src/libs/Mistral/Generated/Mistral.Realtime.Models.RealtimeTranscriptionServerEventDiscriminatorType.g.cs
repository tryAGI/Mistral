
#nullable enable

namespace Mistral.Realtime
{
    /// <summary>
    /// 
    /// </summary>
    public enum RealtimeTranscriptionServerEventDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        Error,
        /// <summary>
        /// 
        /// </summary>
        SessionCreated,
        /// <summary>
        /// 
        /// </summary>
        SessionUpdated,
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
    public static class RealtimeTranscriptionServerEventDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeTranscriptionServerEventDiscriminatorType value)
        {
            return value switch
            {
                RealtimeTranscriptionServerEventDiscriminatorType.Error => "error",
                RealtimeTranscriptionServerEventDiscriminatorType.SessionCreated => "session.created",
                RealtimeTranscriptionServerEventDiscriminatorType.SessionUpdated => "session.updated",
                RealtimeTranscriptionServerEventDiscriminatorType.TranscriptionDone => "transcription.done",
                RealtimeTranscriptionServerEventDiscriminatorType.TranscriptionLanguage => "transcription.language",
                RealtimeTranscriptionServerEventDiscriminatorType.TranscriptionSegment => "transcription.segment",
                RealtimeTranscriptionServerEventDiscriminatorType.TranscriptionTextDelta => "transcription.text.delta",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeTranscriptionServerEventDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "error" => RealtimeTranscriptionServerEventDiscriminatorType.Error,
                "session.created" => RealtimeTranscriptionServerEventDiscriminatorType.SessionCreated,
                "session.updated" => RealtimeTranscriptionServerEventDiscriminatorType.SessionUpdated,
                "transcription.done" => RealtimeTranscriptionServerEventDiscriminatorType.TranscriptionDone,
                "transcription.language" => RealtimeTranscriptionServerEventDiscriminatorType.TranscriptionLanguage,
                "transcription.segment" => RealtimeTranscriptionServerEventDiscriminatorType.TranscriptionSegment,
                "transcription.text.delta" => RealtimeTranscriptionServerEventDiscriminatorType.TranscriptionTextDelta,
                _ => null,
            };
        }
    }
}