
#nullable enable

namespace Mistral
{
    /// <summary>
    /// Default Value: list
    /// </summary>
    public enum JobsOutObject
    {
        /// <summary>
        /// 
        /// </summary>
        List,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class JobsOutObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this JobsOutObject value)
        {
            return value switch
            {
                JobsOutObject.List => "list",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static JobsOutObject? ToEnum(string value)
        {
            return value switch
            {
                "list" => JobsOutObject.List,
                _ => null,
            };
        }
    }
}