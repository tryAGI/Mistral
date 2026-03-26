
#nullable enable

namespace Mistral
{
    /// <summary>
    /// 
    /// </summary>
    public enum SpeechStreamEventsEvent
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
    public static class SpeechStreamEventsEventExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SpeechStreamEventsEvent value)
        {
            return value switch
            {
                SpeechStreamEventsEvent.SpeechAudioDelta => "speech.audio.delta",
                SpeechStreamEventsEvent.SpeechAudioDone => "speech.audio.done",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SpeechStreamEventsEvent? ToEnum(string value)
        {
            return value switch
            {
                "speech.audio.delta" => SpeechStreamEventsEvent.SpeechAudioDelta,
                "speech.audio.done" => SpeechStreamEventsEvent.SpeechAudioDone,
                _ => null,
            };
        }
    }
}