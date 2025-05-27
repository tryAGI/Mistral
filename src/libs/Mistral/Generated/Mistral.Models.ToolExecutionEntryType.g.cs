
#nullable enable

namespace Mistral
{
    /// <summary>
    /// Default Value: tool.execution
    /// </summary>
    public enum ToolExecutionEntryType
    {
        /// <summary>
        /// 
        /// </summary>
        ToolExecution,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ToolExecutionEntryTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ToolExecutionEntryType value)
        {
            return value switch
            {
                ToolExecutionEntryType.ToolExecution => "tool.execution",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ToolExecutionEntryType? ToEnum(string value)
        {
            return value switch
            {
                "tool.execution" => ToolExecutionEntryType.ToolExecution,
                _ => null,
            };
        }
    }
}