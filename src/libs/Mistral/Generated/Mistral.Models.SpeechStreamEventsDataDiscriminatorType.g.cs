
#nullable enable

namespace Mistral
{
    /// <summary>
    /// 
    /// </summary>
    public enum SpeechStreamEventsDataDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        SpeechAudioDelta,
        /// <summary>
        /// 
        /// </summary>
        SpeechAudioDone,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SpeechStreamEventsDataDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SpeechStreamEventsDataDiscriminatorType value)
        {
            return value switch
            {
                SpeechStreamEventsDataDiscriminatorType.SpeechAudioDelta => "speech.audio.delta",
                SpeechStreamEventsDataDiscriminatorType.SpeechAudioDone => "speech.audio.done",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SpeechStreamEventsDataDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "speech.audio.delta" => SpeechStreamEventsDataDiscriminatorType.SpeechAudioDelta,
                "speech.audio.done" => SpeechStreamEventsDataDiscriminatorType.SpeechAudioDone,
                _ => null,
            };
        }
    }
}