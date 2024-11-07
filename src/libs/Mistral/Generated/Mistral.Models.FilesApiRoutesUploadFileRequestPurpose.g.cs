
#nullable enable

namespace Mistral
{
    /// <summary>
    /// 
    /// </summary>
    public enum FilesApiRoutesUploadFileRequestPurpose
    {
        /// <summary>
        /// 
        /// </summary>
        FineTune,
        /// <summary>
        /// 
        /// </summary>
        Batch,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FilesApiRoutesUploadFileRequestPurposeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FilesApiRoutesUploadFileRequestPurpose value)
        {
            return value switch
            {
                FilesApiRoutesUploadFileRequestPurpose.FineTune => "fine-tune",
                FilesApiRoutesUploadFileRequestPurpose.Batch => "batch",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FilesApiRoutesUploadFileRequestPurpose? ToEnum(string value)
        {
            return value switch
            {
                "fine-tune" => FilesApiRoutesUploadFileRequestPurpose.FineTune,
                "batch" => FilesApiRoutesUploadFileRequestPurpose.Batch,
                _ => null,
            };
        }
    }
}