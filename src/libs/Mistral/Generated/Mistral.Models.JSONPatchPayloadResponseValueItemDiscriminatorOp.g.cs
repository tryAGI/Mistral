
#nullable enable

namespace Mistral
{
    /// <summary>
    /// 
    /// </summary>
    public enum JSONPatchPayloadResponseValueItemDiscriminatorOp
    {
        /// <summary>
        /// 
        /// </summary>
        Add,
        /// <summary>
        /// 
        /// </summary>
        Append,
        /// <summary>
        /// 
        /// </summary>
        Remove,
        /// <summary>
        /// 
        /// </summary>
        Replace,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class JSONPatchPayloadResponseValueItemDiscriminatorOpExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this JSONPatchPayloadResponseValueItemDiscriminatorOp value)
        {
            return value switch
            {
                JSONPatchPayloadResponseValueItemDiscriminatorOp.Add => "add",
                JSONPatchPayloadResponseValueItemDiscriminatorOp.Append => "append",
                JSONPatchPayloadResponseValueItemDiscriminatorOp.Remove => "remove",
                JSONPatchPayloadResponseValueItemDiscriminatorOp.Replace => "replace",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static JSONPatchPayloadResponseValueItemDiscriminatorOp? ToEnum(string value)
        {
            return value switch
            {
                "add" => JSONPatchPayloadResponseValueItemDiscriminatorOp.Add,
                "append" => JSONPatchPayloadResponseValueItemDiscriminatorOp.Append,
                "remove" => JSONPatchPayloadResponseValueItemDiscriminatorOp.Remove,
                "replace" => JSONPatchPayloadResponseValueItemDiscriminatorOp.Replace,
                _ => null,
            };
        }
    }
}