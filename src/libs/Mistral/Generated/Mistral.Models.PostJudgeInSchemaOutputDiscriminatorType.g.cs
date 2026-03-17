
#nullable enable

namespace Mistral
{
    /// <summary>
    /// 
    /// </summary>
    public enum PostJudgeInSchemaOutputDiscriminatorType
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
    public static class PostJudgeInSchemaOutputDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PostJudgeInSchemaOutputDiscriminatorType value)
        {
            return value switch
            {
                PostJudgeInSchemaOutputDiscriminatorType.Classification => "CLASSIFICATION",
                PostJudgeInSchemaOutputDiscriminatorType.Regression => "REGRESSION",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PostJudgeInSchemaOutputDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "CLASSIFICATION" => PostJudgeInSchemaOutputDiscriminatorType.Classification,
                "REGRESSION" => PostJudgeInSchemaOutputDiscriminatorType.Regression,
                _ => null,
            };
        }
    }
}