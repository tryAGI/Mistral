
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
    public static class ConnectorSupportedLanguageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConnectorSupportedLanguage value)
        {
            return value switch
            {
                ConnectorSupportedLanguage.Ar => "ar",
                ConnectorSupportedLanguage.De => "de",
                ConnectorSupportedLanguage.En => "en",
                ConnectorSupportedLanguage.Es => "es",
                ConnectorSupportedLanguage.Fr => "fr",
                ConnectorSupportedLanguage.It => "it",
                ConnectorSupportedLanguage.Nl => "nl",
                ConnectorSupportedLanguage.Pl => "pl",
                ConnectorSupportedLanguage.PtBr => "pt-BR",
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
                "ar" => ConnectorSupportedLanguage.Ar,
                "de" => ConnectorSupportedLanguage.De,
                "en" => ConnectorSupportedLanguage.En,
                "es" => ConnectorSupportedLanguage.Es,
                "fr" => ConnectorSupportedLanguage.Fr,
                "it" => ConnectorSupportedLanguage.It,
                "nl" => ConnectorSupportedLanguage.Nl,
                "pl" => ConnectorSupportedLanguage.Pl,
                "pt-BR" => ConnectorSupportedLanguage.PtBr,
                _ => null,
            };
        }
    }
}