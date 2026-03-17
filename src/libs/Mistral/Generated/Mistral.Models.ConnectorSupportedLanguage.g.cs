
#nullable enable

namespace Mistral
{
    /// <summary>
    /// 
    /// </summary>
    public enum ConnectorSupportedLanguage
    {
        /// <summary>
        /// 
        /// </summary>
        En,
        /// <summary>
        /// 
        /// </summary>
        Fr,
        /// <summary>
        /// 
        /// </summary>
        Ar,
        /// <summary>
        /// 
        /// </summary>
        Es,
        /// <summary>
        /// 
        /// </summary>
        De,
        /// <summary>
        /// 
        /// </summary>
        Pl,
        /// <summary>
        /// 
        /// </summary>
        PtBr,
        /// <summary>
        /// 
        /// </summary>
        It,
        /// <summary>
        /// 
        /// </summary>
        Nl,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ConnectorSupportedLanguageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConnectorSupportedLanguage value)
        {
            return value switch
            {
                ConnectorSupportedLanguage.En => "en",
                ConnectorSupportedLanguage.Fr => "fr",
                ConnectorSupportedLanguage.Ar => "ar",
                ConnectorSupportedLanguage.Es => "es",
                ConnectorSupportedLanguage.De => "de",
                ConnectorSupportedLanguage.Pl => "pl",
                ConnectorSupportedLanguage.PtBr => "pt-BR",
                ConnectorSupportedLanguage.It => "it",
                ConnectorSupportedLanguage.Nl => "nl",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConnectorSupportedLanguage? ToEnum(string value)
        {
            return value switch
            {
                "en" => ConnectorSupportedLanguage.En,
                "fr" => ConnectorSupportedLanguage.Fr,
                "ar" => ConnectorSupportedLanguage.Ar,
                "es" => ConnectorSupportedLanguage.Es,
                "de" => ConnectorSupportedLanguage.De,
                "pl" => ConnectorSupportedLanguage.Pl,
                "pt-BR" => ConnectorSupportedLanguage.PtBr,
                "it" => ConnectorSupportedLanguage.It,
                "nl" => ConnectorSupportedLanguage.Nl,
                _ => null,
            };
        }
    }
}