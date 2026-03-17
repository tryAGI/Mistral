
#nullable enable

namespace Mistral
{
    /// <summary>
    /// Default Value: api-key
    /// </summary>
    public enum APIKeyAuthType
    {
        /// <summary>
        /// 
        /// </summary>
        ApiKey,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class APIKeyAuthTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this APIKeyAuthType value)
        {
            return value switch
            {
                APIKeyAuthType.ApiKey => "api-key",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static APIKeyAuthType? ToEnum(string value)
        {
            return value switch
            {
                "api-key" => APIKeyAuthType.ApiKey,
                _ => null,
            };
        }
    }
}