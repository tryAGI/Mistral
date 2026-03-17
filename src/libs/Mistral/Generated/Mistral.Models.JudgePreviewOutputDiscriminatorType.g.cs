
#nullable enable

namespace Mistral
{
    /// <summary>
    /// 
    /// </summary>
    public enum JudgePreviewOutputDiscriminatorType
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
    public static class JudgePreviewOutputDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this JudgePreviewOutputDiscriminatorType value)
        {
            return value switch
            {
                JudgePreviewOutputDiscriminatorType.Classification => "CLASSIFICATION",
                JudgePreviewOutputDiscriminatorType.Regression => "REGRESSION",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static JudgePreviewOutputDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "CLASSIFICATION" => JudgePreviewOutputDiscriminatorType.Classification,
                "REGRESSION" => JudgePreviewOutputDiscriminatorType.Regression,
                _ => null,
            };
        }
    }
}