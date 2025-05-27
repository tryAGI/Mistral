
#nullable enable

namespace Mistral
{
    /// <summary>
    /// Default Value: function.call.delta
    /// </summary>
    public enum FunctionCallEventType
    {
        /// <summary>
        /// 
        /// </summary>
        FunctionCallDelta,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FunctionCallEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FunctionCallEventType value)
        {
            return value switch
            {
                FunctionCallEventType.FunctionCallDelta => "function.call.delta",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FunctionCallEventType? ToEnum(string value)
        {
            return value switch
            {
                "function.call.delta" => FunctionCallEventType.FunctionCallDelta,
                _ => null,
            };
        }
    }
}