
#nullable enable

namespace Mistral
{
    /// <summary>
    /// 
    /// </summary>
    public enum ConversationRequestBaseToolsVariant1ItemDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        CodeInterpreter,
        /// <summary>
        /// 
        /// </summary>
        Connector,
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
    public static class ConversationRequestBaseToolsVariant1ItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConversationRequestBaseToolsVariant1ItemDiscriminatorType value)
        {
            return value switch
            {
                ConversationRequestBaseToolsVariant1ItemDiscriminatorType.CodeInterpreter => "code_interpreter",
                ConversationRequestBaseToolsVariant1ItemDiscriminatorType.Connector => "connector",
                ConversationRequestBaseToolsVariant1ItemDiscriminatorType.DocumentLibrary => "document_library",
                ConversationRequestBaseToolsVariant1ItemDiscriminatorType.Function => "function",
                ConversationRequestBaseToolsVariant1ItemDiscriminatorType.ImageGeneration => "image_generation",
                ConversationRequestBaseToolsVariant1ItemDiscriminatorType.WebSearch => "web_search",
                ConversationRequestBaseToolsVariant1ItemDiscriminatorType.WebSearchPremium => "web_search_premium",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConversationRequestBaseToolsVariant1ItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "code_interpreter" => ConversationRequestBaseToolsVariant1ItemDiscriminatorType.CodeInterpreter,
                "connector" => ConversationRequestBaseToolsVariant1ItemDiscriminatorType.Connector,
                "document_library" => ConversationRequestBaseToolsVariant1ItemDiscriminatorType.DocumentLibrary,
                "function" => ConversationRequestBaseToolsVariant1ItemDiscriminatorType.Function,
                "image_generation" => ConversationRequestBaseToolsVariant1ItemDiscriminatorType.ImageGeneration,
                "web_search" => ConversationRequestBaseToolsVariant1ItemDiscriminatorType.WebSearch,
                "web_search_premium" => ConversationRequestBaseToolsVariant1ItemDiscriminatorType.WebSearchPremium,
                _ => null,
            };
        }
    }
}