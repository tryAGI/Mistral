
#nullable enable

namespace Mistral
{
    /// <summary>
    /// 
    /// </summary>
    public enum MCPSupportedLanguage
    {
        /// <summary>
        /// 
        /// </summary>
        Ar,
        /// <summary>
        /// 
        /// </summary>
        De,
        /// <summary>
        /// 
        /// </summary>
        En,
        /// <summary>
        /// 
        /// </summary>
        Es,
        /// <summary>
        /// 
        /// </summary>
        Fr,
        /// <summary>
        /// 
        /// </summary>
        It,
        /// <summary>
        /// 
        /// </summary>
        Nl,
        /// <summary>
        /// 
        /// </summary>
        Pl,
        /// <summary>
        /// 
        /// </summary>
        PtBr,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MCPSupportedLanguageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MCPSupportedLanguage value)
        {
            return value switch
            {
                MCPSupportedLanguage.Ar => "ar",
                MCPSupportedLanguage.De => "de",
                MCPSupportedLanguage.En => "en",
                MCPSupportedLanguage.Es => "es",
                MCPSupportedLanguage.Fr => "fr",
                MCPSupportedLanguage.It => "it",
                MCPSupportedLanguage.Nl => "nl",
                MCPSupportedLanguage.Pl => "pl",
                MCPSupportedLanguage.PtBr => "pt-BR",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MCPSupportedLanguage? ToEnum(string value)
        {
            return value switch
            {
                "ar" => MCPSupportedLanguage.Ar,
                "de" => MCPSupportedLanguage.De,
                "en" => MCPSupportedLanguage.En,
                "es" => MCPSupportedLanguage.Es,
                "fr" => MCPSupportedLanguage.Fr,
                "it" => MCPSupportedLanguage.It,
                "nl" => MCPSupportedLanguage.Nl,
                "pl" => MCPSupportedLanguage.Pl,
                "pt-BR" => MCPSupportedLanguage.PtBr,
                _ => null,
            };
        }
    }
}