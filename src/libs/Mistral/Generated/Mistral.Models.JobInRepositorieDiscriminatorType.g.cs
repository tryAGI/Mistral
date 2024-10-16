
#nullable enable

namespace Mistral
{
    /// <summary>
    /// 
    /// </summary>
    public enum JobInRepositorieDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        Github,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class JobInRepositorieDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this JobInRepositorieDiscriminatorType value)
        {
            return value switch
            {
                JobInRepositorieDiscriminatorType.Github => "github",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static JobInRepositorieDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "github" => JobInRepositorieDiscriminatorType.Github,
                _ => null,
            };
        }
    }
}