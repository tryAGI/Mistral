
#nullable enable

namespace Mistral.Realtime
{
    /// <summary>
    /// 
    /// </summary>
    public enum ServerEventDiscriminatorType
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
    public static class ServerEventDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ServerEventDiscriminatorType value)
        {
            return value switch
            {
                ServerEventDiscriminatorType.Error => "error",
                ServerEventDiscriminatorType.SessionCreated => "session.created",
                ServerEventDiscriminatorType.SessionUpdated => "session.updated",
                ServerEventDiscriminatorType.TranscriptionDone => "transcription.done",
                ServerEventDiscriminatorType.TranscriptionLanguage => "transcription.language",
                ServerEventDiscriminatorType.TranscriptionSegment => "transcription.segment",
                ServerEventDiscriminatorType.TranscriptionTextDelta => "transcription.text.delta",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ServerEventDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "error" => ServerEventDiscriminatorType.Error,
                "session.created" => ServerEventDiscriminatorType.SessionCreated,
                "session.updated" => ServerEventDiscriminatorType.SessionUpdated,
                "transcription.done" => ServerEventDiscriminatorType.TranscriptionDone,
                "transcription.language" => ServerEventDiscriminatorType.TranscriptionLanguage,
                "transcription.segment" => ServerEventDiscriminatorType.TranscriptionSegment,
                "transcription.text.delta" => ServerEventDiscriminatorType.TranscriptionTextDelta,
                _ => null,
            };
        }
    }
}