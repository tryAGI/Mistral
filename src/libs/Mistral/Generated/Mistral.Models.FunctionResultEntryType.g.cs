
#nullable enable

namespace Mistral
{
    /// <summary>
    /// Default Value: function.result
    /// </summary>
    public enum FunctionResultEntryType
    {
        /// <summary>
        /// 
        /// </summary>
        FunctionResult,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FunctionResultEntryTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FunctionResultEntryType value)
        {
            return value switch
            {
                FunctionResultEntryType.FunctionResult => "function.result",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FunctionResultEntryType? ToEnum(string value)
        {
            return value switch
            {
                "function.result" => FunctionResultEntryType.FunctionResult,
                _ => null,
            };
        }
    }
}