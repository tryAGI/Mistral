
#nullable enable

namespace Mistral
{
    /// <summary>
    /// 
    /// </summary>
    public enum EventType
    {
        /// <summary>
        /// 
        /// </summary>
        Event,
        /// <summary>
        /// 
        /// </summary>
        EventProgress,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EventType value)
        {
            return value switch
            {
                EventType.Event => "EVENT",
                EventType.EventProgress => "EVENT_PROGRESS",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EventType? ToEnum(string value)
        {
            return value switch
            {
                "EVENT" => EventType.Event,
                "EVENT_PROGRESS" => EventType.EventProgress,
                _ => null,
            };
        }
    }
}