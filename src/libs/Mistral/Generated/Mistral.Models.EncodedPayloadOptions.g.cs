
#nullable enable

namespace Mistral
{
    /// <summary>
    /// 
    /// </summary>
    public enum EncodedPayloadOptions
    {
        /// <summary>
        /// 
        /// </summary>
        Encrypted,
        /// <summary>
        /// 
        /// </summary>
        EncryptedPartial,
        /// <summary>
        /// 
        /// </summary>
        Offloaded,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EncodedPayloadOptionsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EncodedPayloadOptions value)
        {
            return value switch
            {
                EncodedPayloadOptions.Encrypted => "encrypted",
                EncodedPayloadOptions.EncryptedPartial => "encrypted-partial",
                EncodedPayloadOptions.Offloaded => "offloaded",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EncodedPayloadOptions? ToEnum(string value)
        {
            return value switch
            {
                "encrypted" => EncodedPayloadOptions.Encrypted,
                "encrypted-partial" => EncodedPayloadOptions.EncryptedPartial,
                "offloaded" => EncodedPayloadOptions.Offloaded,
                _ => null,
            };
        }
    }
}