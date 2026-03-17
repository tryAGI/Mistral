
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
        Workspace,
        /// <summary>
        /// 
        /// </summary>
        User,
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
                FilesApiRoutesUploadFileRequestVisibility.Workspace => "workspace",
                FilesApiRoutesUploadFileRequestVisibility.User => "user",
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
                "workspace" => FilesApiRoutesUploadFileRequestVisibility.Workspace,
                "user" => FilesApiRoutesUploadFileRequestVisibility.User,
                _ => null,
            };
        }
    }
}