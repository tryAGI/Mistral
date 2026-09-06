
#nullable enable

namespace Mistral
{
    /// <summary>
    ///
    /// </summary>
    public enum FunctionCallEventConfirmationStatus
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
    public static class FunctionCallEventConfirmationStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FunctionCallEventConfirmationStatus value)
        {
            return value switch
            {
                FunctionCallEventConfirmationStatus.Allowed => "allowed",
                FunctionCallEventConfirmationStatus.Denied => "denied",
                FunctionCallEventConfirmationStatus.Pending => "pending",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FunctionCallEventConfirmationStatus? ToEnum(string value)
        {
            return value switch
            {
                "allowed" => FunctionCallEventConfirmationStatus.Allowed,
                "denied" => FunctionCallEventConfirmationStatus.Denied,
                "pending" => FunctionCallEventConfirmationStatus.Pending,
                _ => null,
            };
        }
    }
}