
#nullable enable

namespace Mistral
{
    /// <summary>
    /// 
    /// </summary>
    public enum RealtimeTranscriptionClientMessageDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        InputAudioAppend,
        /// <summary>
        /// 
        /// </summary>
        InputAudioEnd,
        /// <summary>
        /// 
        /// </summary>
        InputAudioFlush,
        /// <summary>
        /// 
        /// </summary>
        SessionUpdate,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RealtimeTranscriptionClientMessageDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeTranscriptionClientMessageDiscriminatorType value)
        {
            return value switch
            {
                RealtimeTranscriptionClientMessageDiscriminatorType.InputAudioAppend => "input_audio.append",
                RealtimeTranscriptionClientMessageDiscriminatorType.InputAudioEnd => "input_audio.end",
                RealtimeTranscriptionClientMessageDiscriminatorType.InputAudioFlush => "input_audio.flush",
                RealtimeTranscriptionClientMessageDiscriminatorType.SessionUpdate => "session.update",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeTranscriptionClientMessageDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "input_audio.append" => RealtimeTranscriptionClientMessageDiscriminatorType.InputAudioAppend,
                "input_audio.end" => RealtimeTranscriptionClientMessageDiscriminatorType.InputAudioEnd,
                "input_audio.flush" => RealtimeTranscriptionClientMessageDiscriminatorType.InputAudioFlush,
                "session.update" => RealtimeTranscriptionClientMessageDiscriminatorType.SessionUpdate,
                _ => null,
            };
        }
    }
}