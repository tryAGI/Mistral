
#nullable enable

namespace Mistral
{
    /// <summary>
    /// 
    /// </summary>
    public enum WorkflowEventType
    {
        /// <summary>
        /// 
        /// </summary>
        ActivityTaskCompleted,
        /// <summary>
        /// 
        /// </summary>
        ActivityTaskFailed,
        /// <summary>
        /// 
        /// </summary>
        ActivityTaskRetrying,
        /// <summary>
        /// 
        /// </summary>
        ActivityTaskStarted,
        /// <summary>
        /// 
        /// </summary>
        CustomTaskCanceled,
        /// <summary>
        /// 
        /// </summary>
        CustomTaskCompleted,
        /// <summary>
        /// 
        /// </summary>
        CustomTaskFailed,
        /// <summary>
        /// 
        /// </summary>
        CustomTaskInProgress,
        /// <summary>
        /// 
        /// </summary>
        CustomTaskStarted,
        /// <summary>
        /// 
        /// </summary>
        CustomTaskTimedOut,
        /// <summary>
        /// 
        /// </summary>
        WorkflowExecutionCanceled,
        /// <summary>
        /// 
        /// </summary>
        WorkflowExecutionCompleted,
        /// <summary>
        /// 
        /// </summary>
        WorkflowExecutionContinuedAsNew,
        /// <summary>
        /// 
        /// </summary>
        WorkflowExecutionFailed,
        /// <summary>
        /// 
        /// </summary>
        WorkflowExecutionStarted,
        /// <summary>
        /// 
        /// </summary>
        WorkflowTaskFailed,
        /// <summary>
        /// 
        /// </summary>
        WorkflowTaskTimedOut,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WorkflowEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WorkflowEventType value)
        {
            return value switch
            {
                WorkflowEventType.ActivityTaskCompleted => "ACTIVITY_TASK_COMPLETED",
                WorkflowEventType.ActivityTaskFailed => "ACTIVITY_TASK_FAILED",
                WorkflowEventType.ActivityTaskRetrying => "ACTIVITY_TASK_RETRYING",
                WorkflowEventType.ActivityTaskStarted => "ACTIVITY_TASK_STARTED",
                WorkflowEventType.CustomTaskCanceled => "CUSTOM_TASK_CANCELED",
                WorkflowEventType.CustomTaskCompleted => "CUSTOM_TASK_COMPLETED",
                WorkflowEventType.CustomTaskFailed => "CUSTOM_TASK_FAILED",
                WorkflowEventType.CustomTaskInProgress => "CUSTOM_TASK_IN_PROGRESS",
                WorkflowEventType.CustomTaskStarted => "CUSTOM_TASK_STARTED",
                WorkflowEventType.CustomTaskTimedOut => "CUSTOM_TASK_TIMED_OUT",
                WorkflowEventType.WorkflowExecutionCanceled => "WORKFLOW_EXECUTION_CANCELED",
                WorkflowEventType.WorkflowExecutionCompleted => "WORKFLOW_EXECUTION_COMPLETED",
                WorkflowEventType.WorkflowExecutionContinuedAsNew => "WORKFLOW_EXECUTION_CONTINUED_AS_NEW",
                WorkflowEventType.WorkflowExecutionFailed => "WORKFLOW_EXECUTION_FAILED",
                WorkflowEventType.WorkflowExecutionStarted => "WORKFLOW_EXECUTION_STARTED",
                WorkflowEventType.WorkflowTaskFailed => "WORKFLOW_TASK_FAILED",
                WorkflowEventType.WorkflowTaskTimedOut => "WORKFLOW_TASK_TIMED_OUT",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WorkflowEventType? ToEnum(string value)
        {
            return value switch
            {
                "ACTIVITY_TASK_COMPLETED" => WorkflowEventType.ActivityTaskCompleted,
                "ACTIVITY_TASK_FAILED" => WorkflowEventType.ActivityTaskFailed,
                "ACTIVITY_TASK_RETRYING" => WorkflowEventType.ActivityTaskRetrying,
                "ACTIVITY_TASK_STARTED" => WorkflowEventType.ActivityTaskStarted,
                "CUSTOM_TASK_CANCELED" => WorkflowEventType.CustomTaskCanceled,
                "CUSTOM_TASK_COMPLETED" => WorkflowEventType.CustomTaskCompleted,
                "CUSTOM_TASK_FAILED" => WorkflowEventType.CustomTaskFailed,
                "CUSTOM_TASK_IN_PROGRESS" => WorkflowEventType.CustomTaskInProgress,
                "CUSTOM_TASK_STARTED" => WorkflowEventType.CustomTaskStarted,
                "CUSTOM_TASK_TIMED_OUT" => WorkflowEventType.CustomTaskTimedOut,
                "WORKFLOW_EXECUTION_CANCELED" => WorkflowEventType.WorkflowExecutionCanceled,
                "WORKFLOW_EXECUTION_COMPLETED" => WorkflowEventType.WorkflowExecutionCompleted,
                "WORKFLOW_EXECUTION_CONTINUED_AS_NEW" => WorkflowEventType.WorkflowExecutionContinuedAsNew,
                "WORKFLOW_EXECUTION_FAILED" => WorkflowEventType.WorkflowExecutionFailed,
                "WORKFLOW_EXECUTION_STARTED" => WorkflowEventType.WorkflowExecutionStarted,
                "WORKFLOW_TASK_FAILED" => WorkflowEventType.WorkflowTaskFailed,
                "WORKFLOW_TASK_TIMED_OUT" => WorkflowEventType.WorkflowTaskTimedOut,
                _ => null,
            };
        }
    }
}