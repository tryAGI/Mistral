
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
        Done,
        /// <summary>
        /// 
        /// </summary>
        Error,
        /// <summary>
        /// 
        /// </summary>
        InProgress,
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
        SelfManaged,
        /// <summary>
        /// 
        /// </summary>
        Todo,
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
                ProcessStatus.Done => "done",
                ProcessStatus.Error => "error",
                ProcessStatus.InProgress => "in_progress",
                ProcessStatus.MissingContent => "missing_content",
                ProcessStatus.Noop => "noop",
                ProcessStatus.SelfManaged => "self_managed",
                ProcessStatus.Todo => "todo",
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
                "done" => ProcessStatus.Done,
                "error" => ProcessStatus.Error,
                "in_progress" => ProcessStatus.InProgress,
                "missing_content" => ProcessStatus.MissingContent,
                "noop" => ProcessStatus.Noop,
                "self_managed" => ProcessStatus.SelfManaged,
                "todo" => ProcessStatus.Todo,
                "waiting_for_capacity" => ProcessStatus.WaitingForCapacity,
                _ => null,
            };
        }
    }
}