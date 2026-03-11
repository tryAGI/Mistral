
#nullable enable

namespace Mistral
{
    /// <summary>
    /// 
    /// </summary>
    public enum ToolCallConfirmationConfirmation
    {
        /// <summary>
        /// 
        /// </summary>
        Allow,
        /// <summary>
        /// 
        /// </summary>
        Deny,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ToolCallConfirmationConfirmationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ToolCallConfirmationConfirmation value)
        {
            return value switch
            {
                ToolCallConfirmationConfirmation.Allow => "allow",
                ToolCallConfirmationConfirmation.Deny => "deny",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ToolCallConfirmationConfirmation? ToEnum(string value)
        {
            return value switch
            {
                "allow" => ToolCallConfirmationConfirmation.Allow,
                "deny" => ToolCallConfirmationConfirmation.Deny,
                _ => null,
            };
        }
    }
}