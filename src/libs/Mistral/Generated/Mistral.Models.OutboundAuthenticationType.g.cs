
#nullable enable

namespace Mistral
{
    /// <summary>
    /// 
    /// </summary>
    public enum OutboundAuthenticationType
    {
        /// <summary>
        /// 
        /// </summary>
        Bearer,
        /// <summary>
        /// 
        /// </summary>
        None,
        /// <summary>
        /// 
        /// </summary>
        Oauth2,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OutboundAuthenticationTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OutboundAuthenticationType value)
        {
            return value switch
            {
                OutboundAuthenticationType.Bearer => "bearer",
                OutboundAuthenticationType.None => "none",
                OutboundAuthenticationType.Oauth2 => "oauth2",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OutboundAuthenticationType? ToEnum(string value)
        {
            return value switch
            {
                "bearer" => OutboundAuthenticationType.Bearer,
                "none" => OutboundAuthenticationType.None,
                "oauth2" => OutboundAuthenticationType.Oauth2,
                _ => null,
            };
        }
    }
}