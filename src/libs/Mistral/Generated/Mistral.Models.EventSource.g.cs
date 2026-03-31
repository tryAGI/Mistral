
#nullable enable

namespace Mistral
{
    /// <summary>
    /// 
    /// </summary>
    public enum EventSource
    {
        /// <summary>
        /// 
        /// </summary>
        Database,
        /// <summary>
        /// 
        /// </summary>
        Live,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EventSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EventSource value)
        {
            return value switch
            {
                EventSource.Database => "DATABASE",
                EventSource.Live => "LIVE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EventSource? ToEnum(string value)
        {
            return value switch
            {
                "DATABASE" => EventSource.Database,
                "LIVE" => EventSource.Live,
                _ => null,
            };
        }
    }
}