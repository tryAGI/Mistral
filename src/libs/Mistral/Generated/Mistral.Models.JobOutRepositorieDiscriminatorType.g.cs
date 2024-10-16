
#nullable enable

namespace Mistral
{
    /// <summary>
    /// 
    /// </summary>
    public enum JobOutRepositorieDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        Github,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class JobOutRepositorieDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this JobOutRepositorieDiscriminatorType value)
        {
            return value switch
            {
                JobOutRepositorieDiscriminatorType.Github => "github",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static JobOutRepositorieDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "github" => JobOutRepositorieDiscriminatorType.Github,
                _ => null,
            };
        }
    }
}