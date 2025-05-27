
#nullable enable

namespace Mistral
{
    /// <summary>
    /// 
    /// </summary>
    public enum AgentUpdateRequestToolDiscriminatorType
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
    public static class AgentUpdateRequestToolDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentUpdateRequestToolDiscriminatorType value)
        {
            return value switch
            {
                AgentUpdateRequestToolDiscriminatorType.CodeInterpreter => "code_interpreter",
                AgentUpdateRequestToolDiscriminatorType.DocumentLibrary => "document_library",
                AgentUpdateRequestToolDiscriminatorType.Function => "function",
                AgentUpdateRequestToolDiscriminatorType.ImageGeneration => "image_generation",
                AgentUpdateRequestToolDiscriminatorType.WebSearch => "web_search",
                AgentUpdateRequestToolDiscriminatorType.WebSearchPremium => "web_search_premium",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentUpdateRequestToolDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "code_interpreter" => AgentUpdateRequestToolDiscriminatorType.CodeInterpreter,
                "document_library" => AgentUpdateRequestToolDiscriminatorType.DocumentLibrary,
                "function" => AgentUpdateRequestToolDiscriminatorType.Function,
                "image_generation" => AgentUpdateRequestToolDiscriminatorType.ImageGeneration,
                "web_search" => AgentUpdateRequestToolDiscriminatorType.WebSearch,
                "web_search_premium" => AgentUpdateRequestToolDiscriminatorType.WebSearchPremium,
                _ => null,
            };
        }
    }
}