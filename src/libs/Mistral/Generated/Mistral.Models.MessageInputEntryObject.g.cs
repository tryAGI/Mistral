
#nullable enable

namespace Mistral
{
    /// <summary>
    /// Default Value: entry
    /// </summary>
    public enum MessageInputEntryObject
    {
        /// <summary>
        /// 
        /// </summary>
        Entry,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MessageInputEntryObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MessageInputEntryObject value)
        {
            return value switch
            {
                MessageInputEntryObject.Entry => "entry",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MessageInputEntryObject? ToEnum(string value)
        {
            return value switch
            {
                "entry" => MessageInputEntryObject.Entry,
                _ => null,
            };
        }
    }
}