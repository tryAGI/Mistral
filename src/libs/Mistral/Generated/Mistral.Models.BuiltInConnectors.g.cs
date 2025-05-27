
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
        WebSearch,
        /// <summary>
        /// 
        /// </summary>
        WebSearchPremium,
        /// <summary>
        /// 
        /// </summary>
        CodeInterpreter,
        /// <summary>
        /// 
        /// </summary>
        ImageGeneration,
        /// <summary>
        /// 
        /// </summary>
        DocumentLibrary,
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
                BuiltInConnectors.WebSearch => "web_search",
                BuiltInConnectors.WebSearchPremium => "web_search_premium",
                BuiltInConnectors.CodeInterpreter => "code_interpreter",
                BuiltInConnectors.ImageGeneration => "image_generation",
                BuiltInConnectors.DocumentLibrary => "document_library",
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
                "web_search" => BuiltInConnectors.WebSearch,
                "web_search_premium" => BuiltInConnectors.WebSearchPremium,
                "code_interpreter" => BuiltInConnectors.CodeInterpreter,
                "image_generation" => BuiltInConnectors.ImageGeneration,
                "document_library" => BuiltInConnectors.DocumentLibrary,
                _ => null,
            };
        }
    }
}