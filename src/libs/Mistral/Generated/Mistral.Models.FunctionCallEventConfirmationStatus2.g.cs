
#nullable enable

namespace Mistral
{
    /// <summary>
    /// 
    /// </summary>
    public enum FunctionCallEventConfirmationStatus2
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
    public static class FunctionCallEventConfirmationStatus2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FunctionCallEventConfirmationStatus2 value)
        {
            return value switch
            {
                FunctionCallEventConfirmationStatus2.Pending => "pending",
                FunctionCallEventConfirmationStatus2.Allowed => "allowed",
                FunctionCallEventConfirmationStatus2.Denied => "denied",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FunctionCallEventConfirmationStatus2? ToEnum(string value)
        {
            return value switch
            {
                "pending" => FunctionCallEventConfirmationStatus2.Pending,
                "allowed" => FunctionCallEventConfirmationStatus2.Allowed,
                "denied" => FunctionCallEventConfirmationStatus2.Denied,
                _ => null,
            };
        }
    }
}