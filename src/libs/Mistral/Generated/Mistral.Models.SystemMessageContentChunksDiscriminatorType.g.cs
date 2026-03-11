
#nullable enable

namespace Mistral
{
    /// <summary>
    /// 
    /// </summary>
    public enum SystemMessageContentChunksDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        Text,
        /// <summary>
        /// 
        /// </summary>
        Thinking,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SystemMessageContentChunksDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SystemMessageContentChunksDiscriminatorType value)
        {
            return value switch
            {
                SystemMessageContentChunksDiscriminatorType.Text => "text",
                SystemMessageContentChunksDiscriminatorType.Thinking => "thinking",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SystemMessageContentChunksDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "text" => SystemMessageContentChunksDiscriminatorType.Text,
                "thinking" => SystemMessageContentChunksDiscriminatorType.Thinking,
                _ => null,
            };
        }
    }
}