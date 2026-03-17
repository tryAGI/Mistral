
#nullable enable

namespace Mistral
{
    /// <summary>
    /// 
    /// </summary>
    public enum FileVisibility
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
    public static class FileVisibilityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FileVisibility value)
        {
            return value switch
            {
                FileVisibility.Workspace => "workspace",
                FileVisibility.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FileVisibility? ToEnum(string value)
        {
            return value switch
            {
                "workspace" => FileVisibility.Workspace,
                "user" => FileVisibility.User,
                _ => null,
            };
        }
    }
}