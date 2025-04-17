
#nullable enable

namespace Mistral
{
    /// <summary>
    /// 
    /// </summary>
    public enum ClassifierJobOutIntegrationDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        Wandb,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ClassifierJobOutIntegrationDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ClassifierJobOutIntegrationDiscriminatorType value)
        {
            return value switch
            {
                ClassifierJobOutIntegrationDiscriminatorType.Wandb => "wandb",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ClassifierJobOutIntegrationDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "wandb" => ClassifierJobOutIntegrationDiscriminatorType.Wandb,
                _ => null,
            };
        }
    }
}