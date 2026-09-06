
#nullable enable

namespace Mistral
{
    /// <summary>
    ///
    /// </summary>
    public enum FunctionCallEntryConfirmationStatus
    {
        /// <summary>
        ///
        /// </summary>
        Allowed,
        /// <summary>
        ///
        /// </summary>
        Denied,
        /// <summary>
        ///
        /// </summary>
        Pending,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FunctionCallEntryConfirmationStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FunctionCallEntryConfirmationStatus value)
        {
            return value switch
            {
                FunctionCallEntryConfirmationStatus.Allowed => "allowed",
                FunctionCallEntryConfirmationStatus.Denied => "denied",
                FunctionCallEntryConfirmationStatus.Pending => "pending",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FunctionCallEntryConfirmationStatus? ToEnum(string value)
        {
            return value switch
            {
                "allowed" => FunctionCallEntryConfirmationStatus.Allowed,
                "denied" => FunctionCallEntryConfirmationStatus.Denied,
                "pending" => FunctionCallEntryConfirmationStatus.Pending,
                _ => null,
            };
        }
    }
}