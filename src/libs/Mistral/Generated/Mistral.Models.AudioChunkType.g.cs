
#nullable enable

namespace Mistral
{
    /// <summary>
    /// Default Value: input_audio
    /// </summary>
    public enum AudioChunkType
    {
        /// <summary>
        /// 
        /// </summary>
        InputAudio,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AudioChunkTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AudioChunkType value)
        {
            return value switch
            {
                AudioChunkType.InputAudio => "input_audio",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AudioChunkType? ToEnum(string value)
        {
            return value switch
            {
                "input_audio" => AudioChunkType.InputAudio,
                _ => null,
            };
        }
    }
}