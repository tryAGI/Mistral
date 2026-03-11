
#nullable enable

namespace Mistral
{
    /// <summary>
    /// 
    /// </summary>
    public enum ProcessStatus
    {
        /// <summary>
        /// 
        /// </summary>
        SelfManaged,
        /// <summary>
        /// 
        /// </summary>
        MissingContent,
        /// <summary>
        /// 
        /// </summary>
        Noop,
        /// <summary>
        /// 
        /// </summary>
        Done,
        /// <summary>
        /// 
        /// </summary>
        Todo,
        /// <summary>
        /// 
        /// </summary>
        InProgress,
        /// <summary>
        /// 
        /// </summary>
        Error,
        /// <summary>
        /// 
        /// </summary>
        WaitingForCapacity,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ProcessStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProcessStatus value)
        {
            return value switch
            {
                ProcessStatus.SelfManaged => "self_managed",
                ProcessStatus.MissingContent => "missing_content",
                ProcessStatus.Noop => "noop",
                ProcessStatus.Done => "done",
                ProcessStatus.Todo => "todo",
                ProcessStatus.InProgress => "in_progress",
                ProcessStatus.Error => "error",
                ProcessStatus.WaitingForCapacity => "waiting_for_capacity",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProcessStatus? ToEnum(string value)
        {
            return value switch
            {
                "self_managed" => ProcessStatus.SelfManaged,
                "missing_content" => ProcessStatus.MissingContent,
                "noop" => ProcessStatus.Noop,
                "done" => ProcessStatus.Done,
                "todo" => ProcessStatus.Todo,
                "in_progress" => ProcessStatus.InProgress,
                "error" => ProcessStatus.Error,
                "waiting_for_capacity" => ProcessStatus.WaitingForCapacity,
                _ => null,
            };
        }
    }
}