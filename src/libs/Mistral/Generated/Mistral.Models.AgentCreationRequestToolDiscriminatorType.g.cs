
#nullable enable

namespace Mistral
{
    /// <summary>
    /// 
    /// </summary>
    public enum AgentCreationRequestToolDiscriminatorType
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
    public static class AgentCreationRequestToolDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentCreationRequestToolDiscriminatorType value)
        {
            return value switch
            {
                AgentCreationRequestToolDiscriminatorType.CodeInterpreter => "code_interpreter",
                AgentCreationRequestToolDiscriminatorType.DocumentLibrary => "document_library",
                AgentCreationRequestToolDiscriminatorType.Function => "function",
                AgentCreationRequestToolDiscriminatorType.ImageGeneration => "image_generation",
                AgentCreationRequestToolDiscriminatorType.WebSearch => "web_search",
                AgentCreationRequestToolDiscriminatorType.WebSearchPremium => "web_search_premium",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentCreationRequestToolDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "code_interpreter" => AgentCreationRequestToolDiscriminatorType.CodeInterpreter,
                "document_library" => AgentCreationRequestToolDiscriminatorType.DocumentLibrary,
                "function" => AgentCreationRequestToolDiscriminatorType.Function,
                "image_generation" => AgentCreationRequestToolDiscriminatorType.ImageGeneration,
                "web_search" => AgentCreationRequestToolDiscriminatorType.WebSearch,
                "web_search_premium" => AgentCreationRequestToolDiscriminatorType.WebSearchPremium,
                _ => null,
            };
        }
    }
}