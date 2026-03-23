
#nullable enable

namespace Mistral
{
    /// <summary>
    /// 
    /// </summary>
    public enum BuiltInConnectors
    {
        /// <summary>
        /// 
        /// </summary>
        CodeInterpreter,
        /// <summary>
        /// 
        /// </summary>
        DocumentLibrary,
        /// <summary>
        /// 
        /// </summary>
        ImageGeneration,
        /// <summary>
        /// 
        /// </summary>
        WebSearch,
        /// <summary>
        /// 
        /// </summary>
        WebSearchPremium,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BuiltInConnectorsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BuiltInConnectors value)
        {
            return value switch
            {
                BuiltInConnectors.CodeInterpreter => "code_interpreter",
                BuiltInConnectors.DocumentLibrary => "document_library",
                BuiltInConnectors.ImageGeneration => "image_generation",
                BuiltInConnectors.WebSearch => "web_search",
                BuiltInConnectors.WebSearchPremium => "web_search_premium",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BuiltInConnectors? ToEnum(string value)
        {
            return value switch
            {
                "code_interpreter" => BuiltInConnectors.CodeInterpreter,
                "document_library" => BuiltInConnectors.DocumentLibrary,
                "image_generation" => BuiltInConnectors.ImageGeneration,
                "web_search" => BuiltInConnectors.WebSearch,
                "web_search_premium" => BuiltInConnectors.WebSearchPremium,
                _ => null,
            };
        }
    }
}