
#nullable enable

namespace Mistral
{
    /// <summary>
    /// 
    /// </summary>
    public enum WorkflowExecutionStatus
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
        RetryingAfterError,
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
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WorkflowExecutionStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WorkflowExecutionStatus value)
        {
            return value switch
            {
                WorkflowExecutionStatus.Canceled => "CANCELED",
                WorkflowExecutionStatus.Completed => "COMPLETED",
                WorkflowExecutionStatus.ContinuedAsNew => "CONTINUED_AS_NEW",
                WorkflowExecutionStatus.Failed => "FAILED",
                WorkflowExecutionStatus.RetryingAfterError => "RETRYING_AFTER_ERROR",
                WorkflowExecutionStatus.Running => "RUNNING",
                WorkflowExecutionStatus.Terminated => "TERMINATED",
                WorkflowExecutionStatus.TimedOut => "TIMED_OUT",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WorkflowExecutionStatus? ToEnum(string value)
        {
            return value switch
            {
                "CANCELED" => WorkflowExecutionStatus.Canceled,
                "COMPLETED" => WorkflowExecutionStatus.Completed,
                "CONTINUED_AS_NEW" => WorkflowExecutionStatus.ContinuedAsNew,
                "FAILED" => WorkflowExecutionStatus.Failed,
                "RETRYING_AFTER_ERROR" => WorkflowExecutionStatus.RetryingAfterError,
                "RUNNING" => WorkflowExecutionStatus.Running,
                "TERMINATED" => WorkflowExecutionStatus.Terminated,
                "TIMED_OUT" => WorkflowExecutionStatus.TimedOut,
                _ => null,
            };
        }
    }
}