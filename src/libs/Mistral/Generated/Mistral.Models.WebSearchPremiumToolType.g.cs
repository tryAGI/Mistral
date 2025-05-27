
#nullable enable

namespace Mistral
{
    /// <summary>
    /// Default Value: web_search_premium
    /// </summary>
    public enum WebSearchPremiumToolType
    {
        /// <summary>
        /// 
        /// </summary>
        WebSearchPremium,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebSearchPremiumToolTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebSearchPremiumToolType value)
        {
            return value switch
            {
                WebSearchPremiumToolType.WebSearchPremium => "web_search_premium",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebSearchPremiumToolType? ToEnum(string value)
        {
            return value switch
            {
                "web_search_premium" => WebSearchPremiumToolType.WebSearchPremium,
                _ => null,
            };
        }
    }
}