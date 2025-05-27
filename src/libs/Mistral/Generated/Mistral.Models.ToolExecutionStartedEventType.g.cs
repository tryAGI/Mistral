
#nullable enable

namespace Mistral
{
    /// <summary>
    /// Default Value: tool.execution.started
    /// </summary>
    public enum ToolExecutionStartedEventType
    {
        /// <summary>
        /// 
        /// </summary>
        ToolExecutionStarted,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ToolExecutionStartedEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ToolExecutionStartedEventType value)
        {
            return value switch
            {
                ToolExecutionStartedEventType.ToolExecutionStarted => "tool.execution.started",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ToolExecutionStartedEventType? ToEnum(string value)
        {
            return value switch
            {
                "tool.execution.started" => ToolExecutionStartedEventType.ToolExecutionStarted,
                _ => null,
            };
        }
    }
}