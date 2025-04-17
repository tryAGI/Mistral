
#nullable enable

namespace Mistral
{
    /// <summary>
    /// 
    /// </summary>
    public enum CompletionJobOutRepositorieDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        Github,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CompletionJobOutRepositorieDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CompletionJobOutRepositorieDiscriminatorType value)
        {
            return value switch
            {
                CompletionJobOutRepositorieDiscriminatorType.Github => "github",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CompletionJobOutRepositorieDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "github" => CompletionJobOutRepositorieDiscriminatorType.Github,
                _ => null,
            };
        }
    }
}