
#nullable enable

namespace Mistral
{
    /// <summary>
    /// 
    /// </summary>
    public enum AgentToolDiscriminatorType
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
        Function,
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
    public static class AgentToolDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentToolDiscriminatorType value)
        {
            return value switch
            {
                AgentToolDiscriminatorType.CodeInterpreter => "code_interpreter",
                AgentToolDiscriminatorType.DocumentLibrary => "document_library",
                AgentToolDiscriminatorType.Function => "function",
                AgentToolDiscriminatorType.ImageGeneration => "image_generation",
                AgentToolDiscriminatorType.WebSearch => "web_search",
                AgentToolDiscriminatorType.WebSearchPremium => "web_search_premium",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentToolDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "code_interpreter" => AgentToolDiscriminatorType.CodeInterpreter,
                "document_library" => AgentToolDiscriminatorType.DocumentLibrary,
                "function" => AgentToolDiscriminatorType.Function,
                "image_generation" => AgentToolDiscriminatorType.ImageGeneration,
                "web_search" => AgentToolDiscriminatorType.WebSearch,
                "web_search_premium" => AgentToolDiscriminatorType.WebSearchPremium,
                _ => null,
            };
        }
    }
}