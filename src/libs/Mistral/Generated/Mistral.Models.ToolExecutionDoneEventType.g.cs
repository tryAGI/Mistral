
#nullable enable

namespace Mistral
{
    /// <summary>
    /// Default Value: tool.execution.done
    /// </summary>
    public enum ToolExecutionDoneEventType
    {
        /// <summary>
        /// 
        /// </summary>
        ToolExecutionDone,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ToolExecutionDoneEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ToolExecutionDoneEventType value)
        {
            return value switch
            {
                ToolExecutionDoneEventType.ToolExecutionDone => "tool.execution.done",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ToolExecutionDoneEventType? ToEnum(string value)
        {
            return value switch
            {
                "tool.execution.done" => ToolExecutionDoneEventType.ToolExecutionDone,
                _ => null,
            };
        }
    }
}