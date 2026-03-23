
#nullable enable

namespace Mistral
{
    /// <summary>
    /// 
    /// </summary>
    public enum AudioEncoding
    {
        /// <summary>
        /// 
        /// </summary>
        PcmAlaw,
        /// <summary>
        /// 
        /// </summary>
        PcmF16le,
        /// <summary>
        /// 
        /// </summary>
        PcmF32le,
        /// <summary>
        /// 
        /// </summary>
        PcmMulaw,
        /// <summary>
        /// 
        /// </summary>
        PcmS16le,
        /// <summary>
        /// 
        /// </summary>
        PcmS32le,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AudioEncodingExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AudioEncoding value)
        {
            return value switch
            {
                AudioEncoding.PcmAlaw => "pcm_alaw",
                AudioEncoding.PcmF16le => "pcm_f16le",
                AudioEncoding.PcmF32le => "pcm_f32le",
                AudioEncoding.PcmMulaw => "pcm_mulaw",
                AudioEncoding.PcmS16le => "pcm_s16le",
                AudioEncoding.PcmS32le => "pcm_s32le",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AudioEncoding? ToEnum(string value)
        {
            return value switch
            {
                "pcm_alaw" => AudioEncoding.PcmAlaw,
                "pcm_f16le" => AudioEncoding.PcmF16le,
                "pcm_f32le" => AudioEncoding.PcmF32le,
                "pcm_mulaw" => AudioEncoding.PcmMulaw,
                "pcm_s16le" => AudioEncoding.PcmS16le,
                "pcm_s32le" => AudioEncoding.PcmS32le,
                _ => null,
            };
        }
    }
}