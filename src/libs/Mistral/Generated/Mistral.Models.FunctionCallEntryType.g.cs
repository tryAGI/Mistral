
#nullable enable

namespace Mistral
{
    /// <summary>
    /// Default Value: function.call
    /// </summary>
    public enum FunctionCallEntryType
    {
        /// <summary>
        /// 
        /// </summary>
        FunctionCall,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FunctionCallEntryTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FunctionCallEntryType value)
        {
            return value switch
            {
                FunctionCallEntryType.FunctionCall => "function.call",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FunctionCallEntryType? ToEnum(string value)
        {
            return value switch
            {
                "function.call" => FunctionCallEntryType.FunctionCall,
                _ => null,
            };
        }
    }
}