
#nullable enable

namespace Mistral
{
    /// <summary>
    /// Default Value: entry
    /// </summary>
    public enum FunctionCallEntryObject
    {
        /// <summary>
        /// 
        /// </summary>
        Entry,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FunctionCallEntryObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FunctionCallEntryObject value)
        {
            return value switch
            {
                FunctionCallEntryObject.Entry => "entry",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FunctionCallEntryObject? ToEnum(string value)
        {
            return value switch
            {
                "entry" => FunctionCallEntryObject.Entry,
                _ => null,
            };
        }
    }
}