
#nullable enable

namespace Mistral
{
    /// <summary>
    /// Default Value: connector
    /// </summary>
    public enum CustomConnectorType
    {
        /// <summary>
        /// 
        /// </summary>
        Connector,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CustomConnectorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CustomConnectorType value)
        {
            return value switch
            {
                CustomConnectorType.Connector => "connector",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CustomConnectorType? ToEnum(string value)
        {
            return value switch
            {
                "connector" => CustomConnectorType.Connector,
                _ => null,
            };
        }
    }
}