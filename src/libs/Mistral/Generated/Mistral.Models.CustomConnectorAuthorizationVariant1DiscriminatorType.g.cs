
#nullable enable

namespace Mistral
{
    /// <summary>
    /// 
    /// </summary>
    public enum CustomConnectorAuthorizationVariant1DiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        ApiKey,
        /// <summary>
        /// 
        /// </summary>
        Oauth2Token,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CustomConnectorAuthorizationVariant1DiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CustomConnectorAuthorizationVariant1DiscriminatorType value)
        {
            return value switch
            {
                CustomConnectorAuthorizationVariant1DiscriminatorType.ApiKey => "api-key",
                CustomConnectorAuthorizationVariant1DiscriminatorType.Oauth2Token => "oauth2-token",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CustomConnectorAuthorizationVariant1DiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "api-key" => CustomConnectorAuthorizationVariant1DiscriminatorType.ApiKey,
                "oauth2-token" => CustomConnectorAuthorizationVariant1DiscriminatorType.Oauth2Token,
                _ => null,
            };
        }
    }
}