
#nullable enable

namespace Mistral
{
    /// <summary>
    /// 
    /// </summary>
    public enum CustomTaskInProgressAttributesResponsePayloadDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        Json,
        /// <summary>
        /// 
        /// </summary>
        JsonPatch,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CustomTaskInProgressAttributesResponsePayloadDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CustomTaskInProgressAttributesResponsePayloadDiscriminatorType value)
        {
            return value switch
            {
                CustomTaskInProgressAttributesResponsePayloadDiscriminatorType.Json => "json",
                CustomTaskInProgressAttributesResponsePayloadDiscriminatorType.JsonPatch => "json_patch",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CustomTaskInProgressAttributesResponsePayloadDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "json" => CustomTaskInProgressAttributesResponsePayloadDiscriminatorType.Json,
                "json_patch" => CustomTaskInProgressAttributesResponsePayloadDiscriminatorType.JsonPatch,
                _ => null,
            };
        }
    }
}