
#nullable enable

namespace Mistral
{
    /// <summary>
    /// 
    /// </summary>
    public enum ConversationRequestBaseToolDiscriminatorType
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
    public static class ConversationRequestBaseToolDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConversationRequestBaseToolDiscriminatorType value)
        {
            return value switch
            {
                ConversationRequestBaseToolDiscriminatorType.CodeInterpreter => "code_interpreter",
                ConversationRequestBaseToolDiscriminatorType.DocumentLibrary => "document_library",
                ConversationRequestBaseToolDiscriminatorType.Function => "function",
                ConversationRequestBaseToolDiscriminatorType.ImageGeneration => "image_generation",
                ConversationRequestBaseToolDiscriminatorType.WebSearch => "web_search",
                ConversationRequestBaseToolDiscriminatorType.WebSearchPremium => "web_search_premium",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConversationRequestBaseToolDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "code_interpreter" => ConversationRequestBaseToolDiscriminatorType.CodeInterpreter,
                "document_library" => ConversationRequestBaseToolDiscriminatorType.DocumentLibrary,
                "function" => ConversationRequestBaseToolDiscriminatorType.Function,
                "image_generation" => ConversationRequestBaseToolDiscriminatorType.ImageGeneration,
                "web_search" => ConversationRequestBaseToolDiscriminatorType.WebSearch,
                "web_search_premium" => ConversationRequestBaseToolDiscriminatorType.WebSearchPremium,
                _ => null,
            };
        }
    }
}