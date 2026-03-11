
#nullable enable

namespace Mistral
{
    /// <summary>
    /// 
    /// </summary>
    public enum ModelConversationToolDiscriminatorType
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
    public static class ModelConversationToolDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ModelConversationToolDiscriminatorType value)
        {
            return value switch
            {
                ModelConversationToolDiscriminatorType.CodeInterpreter => "code_interpreter",
                ModelConversationToolDiscriminatorType.DocumentLibrary => "document_library",
                ModelConversationToolDiscriminatorType.Function => "function",
                ModelConversationToolDiscriminatorType.ImageGeneration => "image_generation",
                ModelConversationToolDiscriminatorType.WebSearch => "web_search",
                ModelConversationToolDiscriminatorType.WebSearchPremium => "web_search_premium",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ModelConversationToolDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "code_interpreter" => ModelConversationToolDiscriminatorType.CodeInterpreter,
                "document_library" => ModelConversationToolDiscriminatorType.DocumentLibrary,
                "function" => ModelConversationToolDiscriminatorType.Function,
                "image_generation" => ModelConversationToolDiscriminatorType.ImageGeneration,
                "web_search" => ModelConversationToolDiscriminatorType.WebSearch,
                "web_search_premium" => ModelConversationToolDiscriminatorType.WebSearchPremium,
                _ => null,
            };
        }
    }
}