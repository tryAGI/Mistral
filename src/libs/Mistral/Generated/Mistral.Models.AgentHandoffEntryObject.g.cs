
#nullable enable

namespace Mistral
{
    /// <summary>
    /// Default Value: entry
    /// </summary>
    public enum AgentHandoffEntryObject
    {
        /// <summary>
        /// 
        /// </summary>
        Entry,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentHandoffEntryObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentHandoffEntryObject value)
        {
            return value switch
            {
                AgentHandoffEntryObject.Entry => "entry",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentHandoffEntryObject? ToEnum(string value)
        {
            return value switch
            {
                "entry" => AgentHandoffEntryObject.Entry,
                _ => null,
            };
        }
    }
}