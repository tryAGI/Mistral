
#nullable enable

namespace Mistral
{
    /// <summary>
    /// Default Value: entry
    /// </summary>
    public enum MessageOutputEntryObject
    {
        /// <summary>
        /// 
        /// </summary>
        Entry,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MessageOutputEntryObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MessageOutputEntryObject value)
        {
            return value switch
            {
                MessageOutputEntryObject.Entry => "entry",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MessageOutputEntryObject? ToEnum(string value)
        {
            return value switch
            {
                "entry" => MessageOutputEntryObject.Entry,
                _ => null,
            };
        }
    }
}