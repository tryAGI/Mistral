
#nullable enable

namespace Mistral
{
    /// <summary>
    /// 
    /// </summary>
    public enum SpeechOutputFormat
    {
        /// <summary>
        /// 
        /// </summary>
        Flac,
        /// <summary>
        /// 
        /// </summary>
        Mp3,
        /// <summary>
        /// 
        /// </summary>
        Opus,
        /// <summary>
        /// 
        /// </summary>
        Pcm,
        /// <summary>
        /// 
        /// </summary>
        Wav,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SpeechOutputFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SpeechOutputFormat value)
        {
            return value switch
            {
                SpeechOutputFormat.Flac => "flac",
                SpeechOutputFormat.Mp3 => "mp3",
                SpeechOutputFormat.Opus => "opus",
                SpeechOutputFormat.Pcm => "pcm",
                SpeechOutputFormat.Wav => "wav",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SpeechOutputFormat? ToEnum(string value)
        {
            return value switch
            {
                "flac" => SpeechOutputFormat.Flac,
                "mp3" => SpeechOutputFormat.Mp3,
                "opus" => SpeechOutputFormat.Opus,
                "pcm" => SpeechOutputFormat.Pcm,
                "wav" => SpeechOutputFormat.Wav,
                _ => null,
            };
        }
    }
}