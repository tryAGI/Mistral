
#nullable enable

namespace Mistral
{
    /// <summary>
    /// 
    /// </summary>
    public enum FunctionCallEntryConfirmationStatus2
    {
        /// <summary>
        /// 
        /// </summary>
        Pending,
        /// <summary>
        /// 
        /// </summary>
        Allowed,
        /// <summary>
        /// 
        /// </summary>
        Denied,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FunctionCallEntryConfirmationStatus2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FunctionCallEntryConfirmationStatus2 value)
        {
            return value switch
            {
                FunctionCallEntryConfirmationStatus2.Pending => "pending",
                FunctionCallEntryConfirmationStatus2.Allowed => "allowed",
                FunctionCallEntryConfirmationStatus2.Denied => "denied",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FunctionCallEntryConfirmationStatus2? ToEnum(string value)
        {
            return value switch
            {
                "pending" => FunctionCallEntryConfirmationStatus2.Pending,
                "allowed" => FunctionCallEntryConfirmationStatus2.Allowed,
                "denied" => FunctionCallEntryConfirmationStatus2.Denied,
                _ => null,
            };
        }
    }
}