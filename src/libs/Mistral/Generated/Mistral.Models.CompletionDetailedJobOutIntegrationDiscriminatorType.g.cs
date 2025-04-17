
#nullable enable

namespace Mistral
{
    /// <summary>
    /// 
    /// </summary>
    public enum CompletionDetailedJobOutIntegrationDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        Wandb,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CompletionDetailedJobOutIntegrationDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CompletionDetailedJobOutIntegrationDiscriminatorType value)
        {
            return value switch
            {
                CompletionDetailedJobOutIntegrationDiscriminatorType.Wandb => "wandb",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CompletionDetailedJobOutIntegrationDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "wandb" => CompletionDetailedJobOutIntegrationDiscriminatorType.Wandb,
                _ => null,
            };
        }
    }
}