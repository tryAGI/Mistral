
#nullable enable

namespace Mistral
{
    /// <summary>
    /// 
    /// </summary>
    public enum MCPUIToolMetaVisibilityVariant1Item
    {
        /// <summary>
        /// 
        /// </summary>
        App,
        /// <summary>
        /// 
        /// </summary>
        Model,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MCPUIToolMetaVisibilityVariant1ItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MCPUIToolMetaVisibilityVariant1Item value)
        {
            return value switch
            {
                MCPUIToolMetaVisibilityVariant1Item.App => "app",
                MCPUIToolMetaVisibilityVariant1Item.Model => "model",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MCPUIToolMetaVisibilityVariant1Item? ToEnum(string value)
        {
            return value switch
            {
                "app" => MCPUIToolMetaVisibilityVariant1Item.App,
                "model" => MCPUIToolMetaVisibilityVariant1Item.Model,
                _ => null,
            };
        }
    }
}