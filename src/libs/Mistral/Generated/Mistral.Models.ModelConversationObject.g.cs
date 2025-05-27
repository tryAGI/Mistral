
#nullable enable

namespace Mistral
{
    /// <summary>
    /// Default Value: conversation
    /// </summary>
    public enum ModelConversationObject
    {
        /// <summary>
        /// 
        /// </summary>
        Conversation,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ModelConversationObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ModelConversationObject value)
        {
            return value switch
            {
                ModelConversationObject.Conversation => "conversation",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ModelConversationObject? ToEnum(string value)
        {
            return value switch
            {
                "conversation" => ModelConversationObject.Conversation,
                _ => null,
            };
        }
    }
}