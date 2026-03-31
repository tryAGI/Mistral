
#nullable enable

namespace Mistral
{
    /// <summary>
    /// 
    /// </summary>
    public enum EventProgressStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Completed,
        /// <summary>
        /// 
        /// </summary>
        Failed,
        /// <summary>
        /// 
        /// </summary>
        Running,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EventProgressStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EventProgressStatus value)
        {
            return value switch
            {
                EventProgressStatus.Completed => "COMPLETED",
                EventProgressStatus.Failed => "FAILED",
                EventProgressStatus.Running => "RUNNING",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EventProgressStatus? ToEnum(string value)
        {
            return value switch
            {
                "COMPLETED" => EventProgressStatus.Completed,
                "FAILED" => EventProgressStatus.Failed,
                "RUNNING" => EventProgressStatus.Running,
                _ => null,
            };
        }
    }
}