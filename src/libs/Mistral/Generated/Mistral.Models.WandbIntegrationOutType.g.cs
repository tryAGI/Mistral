
#nullable enable

namespace Mistral
{
    /// <summary>
    /// Default Value: wandb
    /// </summary>
    public enum WandbIntegrationOutType
    {
        /// <summary>
        /// 
        /// </summary>
        Wandb,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WandbIntegrationOutTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WandbIntegrationOutType value)
        {
            return value switch
            {
                WandbIntegrationOutType.Wandb => "wandb",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WandbIntegrationOutType? ToEnum(string value)
        {
            return value switch
            {
                "wandb" => WandbIntegrationOutType.Wandb,
                _ => null,
            };
        }
    }
}