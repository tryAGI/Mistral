
#nullable enable

namespace Mistral
{
    /// <summary>
    /// 
    /// </summary>
    public enum JobOutIntegrationDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        Wandb,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class JobOutIntegrationDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this JobOutIntegrationDiscriminatorType value)
        {
            return value switch
            {
                JobOutIntegrationDiscriminatorType.Wandb => "wandb",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static JobOutIntegrationDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "wandb" => JobOutIntegrationDiscriminatorType.Wandb,
                _ => null,
            };
        }
    }
}