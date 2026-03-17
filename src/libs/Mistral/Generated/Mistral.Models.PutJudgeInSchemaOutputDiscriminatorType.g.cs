
#nullable enable

namespace Mistral
{
    /// <summary>
    /// 
    /// </summary>
    public enum PutJudgeInSchemaOutputDiscriminatorType
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
    public static class PutJudgeInSchemaOutputDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PutJudgeInSchemaOutputDiscriminatorType value)
        {
            return value switch
            {
                PutJudgeInSchemaOutputDiscriminatorType.Classification => "CLASSIFICATION",
                PutJudgeInSchemaOutputDiscriminatorType.Regression => "REGRESSION",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PutJudgeInSchemaOutputDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "CLASSIFICATION" => PutJudgeInSchemaOutputDiscriminatorType.Classification,
                "REGRESSION" => PutJudgeInSchemaOutputDiscriminatorType.Regression,
                _ => null,
            };
        }
    }
}