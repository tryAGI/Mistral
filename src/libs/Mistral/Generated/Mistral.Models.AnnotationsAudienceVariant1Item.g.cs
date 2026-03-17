
#nullable enable

namespace Mistral
{
    /// <summary>
    /// 
    /// </summary>
    public enum AnnotationsAudienceVariant1Item
    {
        /// <summary>
        /// 
        /// </summary>
        User,
        /// <summary>
        /// 
        /// </summary>
        Assistant,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AnnotationsAudienceVariant1ItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AnnotationsAudienceVariant1Item value)
        {
            return value switch
            {
                AnnotationsAudienceVariant1Item.User => "user",
                AnnotationsAudienceVariant1Item.Assistant => "assistant",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AnnotationsAudienceVariant1Item? ToEnum(string value)
        {
            return value switch
            {
                "user" => AnnotationsAudienceVariant1Item.User,
                "assistant" => AnnotationsAudienceVariant1Item.Assistant,
                _ => null,
            };
        }
    }
}