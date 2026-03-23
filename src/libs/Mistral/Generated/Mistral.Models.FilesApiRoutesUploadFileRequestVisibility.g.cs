
#nullable enable

namespace Mistral
{
    /// <summary>
    /// 
    /// </summary>
    public enum FilesApiRoutesUploadFileRequestVisibility
    {
        /// <summary>
        /// 
        /// </summary>
        User,
        /// <summary>
        /// 
        /// </summary>
        Workspace,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FilesApiRoutesUploadFileRequestVisibilityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FilesApiRoutesUploadFileRequestVisibility value)
        {
            return value switch
            {
                FilesApiRoutesUploadFileRequestVisibility.User => "user",
                FilesApiRoutesUploadFileRequestVisibility.Workspace => "workspace",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FilesApiRoutesUploadFileRequestVisibility? ToEnum(string value)
        {
            return value switch
            {
                "user" => FilesApiRoutesUploadFileRequestVisibility.User,
                "workspace" => FilesApiRoutesUploadFileRequestVisibility.Workspace,
                _ => null,
            };
        }
    }
}