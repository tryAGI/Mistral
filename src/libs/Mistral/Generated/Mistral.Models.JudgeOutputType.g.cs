
#nullable enable

namespace Mistral
{
    /// <summary>
    /// 
    /// </summary>
    public enum JudgeOutputType
    {
        /// <summary>
        /// 
        /// </summary>
        Classification,
        /// <summary>
        /// 
        /// </summary>
        Regression,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class JudgeOutputTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this JudgeOutputType value)
        {
            return value switch
            {
                JudgeOutputType.Classification => "CLASSIFICATION",
                JudgeOutputType.Regression => "REGRESSION",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static JudgeOutputType? ToEnum(string value)
        {
            return value switch
            {
                "CLASSIFICATION" => JudgeOutputType.Classification,
                "REGRESSION" => JudgeOutputType.Regression,
                _ => null,
            };
        }
    }
}