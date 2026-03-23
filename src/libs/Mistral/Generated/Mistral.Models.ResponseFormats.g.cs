
#nullable enable

namespace Mistral
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseFormats
    {
        /// <summary>
        /// 
        /// </summary>
        JsonObject,
        /// <summary>
        /// 
        /// </summary>
        JsonSchema,
        /// <summary>
        /// 
        /// </summary>
        Text,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponseFormatsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseFormats value)
        {
            return value switch
            {
                ResponseFormats.JsonObject => "json_object",
                ResponseFormats.JsonSchema => "json_schema",
                ResponseFormats.Text => "text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseFormats? ToEnum(string value)
        {
            return value switch
            {
                "json_object" => ResponseFormats.JsonObject,
                "json_schema" => ResponseFormats.JsonSchema,
                "text" => ResponseFormats.Text,
                _ => null,
            };
        }
    }
}