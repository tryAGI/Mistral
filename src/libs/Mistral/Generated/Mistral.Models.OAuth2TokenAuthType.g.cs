
#nullable enable

namespace Mistral
{
    /// <summary>
    /// Default Value: oauth2-token
    /// </summary>
    public enum OAuth2TokenAuthType
    {
        /// <summary>
        /// 
        /// </summary>
        Oauth2Token,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OAuth2TokenAuthTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OAuth2TokenAuthType value)
        {
            return value switch
            {
                OAuth2TokenAuthType.Oauth2Token => "oauth2-token",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OAuth2TokenAuthType? ToEnum(string value)
        {
            return value switch
            {
                "oauth2-token" => OAuth2TokenAuthType.Oauth2Token,
                _ => null,
            };
        }
    }
}