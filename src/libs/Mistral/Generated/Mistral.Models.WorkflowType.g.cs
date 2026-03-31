
#nullable enable

namespace Mistral
{
    /// <summary>
    /// 
    /// </summary>
    public enum WorkflowType
    {
        /// <summary>
        /// 
        /// </summary>
        Code,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WorkflowTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WorkflowType value)
        {
            return value switch
            {
                WorkflowType.Code => "code",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WorkflowType? ToEnum(string value)
        {
            return value switch
            {
                "code" => WorkflowType.Code,
                _ => null,
            };
        }
    }
}