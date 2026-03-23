
#nullable enable

namespace Mistral
{
    /// <summary>
    /// 
    /// </summary>
    public enum BaseTaskStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Canceled,
        /// <summary>
        /// 
        /// </summary>
        Completed,
        /// <summary>
        /// 
        /// </summary>
        ContinuedAsNew,
        /// <summary>
        /// 
        /// </summary>
        Failed,
        /// <summary>
        /// 
        /// </summary>
        Running,
        /// <summary>
        /// 
        /// </summary>
        Terminated,
        /// <summary>
        /// 
        /// </summary>
        TimedOut,
        /// <summary>
        /// 
        /// </summary>
        Unknown,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BaseTaskStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BaseTaskStatus value)
        {
            return value switch
            {
                BaseTaskStatus.Canceled => "CANCELED",
                BaseTaskStatus.Completed => "COMPLETED",
                BaseTaskStatus.ContinuedAsNew => "CONTINUED_AS_NEW",
                BaseTaskStatus.Failed => "FAILED",
                BaseTaskStatus.Running => "RUNNING",
                BaseTaskStatus.Terminated => "TERMINATED",
                BaseTaskStatus.TimedOut => "TIMED_OUT",
                BaseTaskStatus.Unknown => "UNKNOWN",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BaseTaskStatus? ToEnum(string value)
        {
            return value switch
            {
                "CANCELED" => BaseTaskStatus.Canceled,
                "COMPLETED" => BaseTaskStatus.Completed,
                "CONTINUED_AS_NEW" => BaseTaskStatus.ContinuedAsNew,
                "FAILED" => BaseTaskStatus.Failed,
                "RUNNING" => BaseTaskStatus.Running,
                "TERMINATED" => BaseTaskStatus.Terminated,
                "TIMED_OUT" => BaseTaskStatus.TimedOut,
                "UNKNOWN" => BaseTaskStatus.Unknown,
                _ => null,
            };
        }
    }
}