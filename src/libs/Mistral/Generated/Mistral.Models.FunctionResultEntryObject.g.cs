
#nullable enable

namespace Mistral
{
    /// <summary>
    /// Default Value: entry
    /// </summary>
    public enum FunctionResultEntryObject
    {
        /// <summary>
        /// 
        /// </summary>
        Entry,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FunctionResultEntryObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FunctionResultEntryObject value)
        {
            return value switch
            {
                FunctionResultEntryObject.Entry => "entry",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FunctionResultEntryObject? ToEnum(string value)
        {
            return value switch
            {
                "entry" => FunctionResultEntryObject.Entry,
                _ => null,
            };
        }
    }
}