
#nullable enable

namespace Mistral
{
    /// <summary>
    /// Default Value: model
    /// </summary>
    public enum FTModelOutObject
    {
        /// <summary>
        /// 
        /// </summary>
        Model,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FTModelOutObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FTModelOutObject value)
        {
            return value switch
            {
                FTModelOutObject.Model => "model",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FTModelOutObject? ToEnum(string value)
        {
            return value switch
            {
                "model" => FTModelOutObject.Model,
                _ => null,
            };
        }
    }
}