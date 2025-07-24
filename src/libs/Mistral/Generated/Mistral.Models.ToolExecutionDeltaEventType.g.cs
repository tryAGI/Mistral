
#nullable enable

namespace Mistral
{
    /// <summary>
    /// Default Value: tool.execution.delta
    /// </summary>
    public enum ToolExecutionDeltaEventType
    {
        /// <summary>
        /// 
        /// </summary>
        ToolExecutionDelta,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ToolExecutionDeltaEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ToolExecutionDeltaEventType value)
        {
            return value switch
            {
                ToolExecutionDeltaEventType.ToolExecutionDelta => "tool.execution.delta",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ToolExecutionDeltaEventType? ToEnum(string value)
        {
            return value switch
            {
                "tool.execution.delta" => ToolExecutionDeltaEventType.ToolExecutionDelta,
                _ => null,
            };
        }
    }
}