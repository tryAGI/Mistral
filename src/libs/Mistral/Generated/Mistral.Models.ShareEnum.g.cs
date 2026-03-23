
#nullable enable

namespace Mistral
{
    /// <summary>
    /// 
    /// </summary>
    public enum ShareEnum
    {
        /// <summary>
        /// 
        /// </summary>
        Editor,
        /// <summary>
        /// 
        /// </summary>
        Viewer,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ShareEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ShareEnum value)
        {
            return value switch
            {
                ShareEnum.Editor => "Editor",
                ShareEnum.Viewer => "Viewer",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ShareEnum? ToEnum(string value)
        {
            return value switch
            {
                "Editor" => ShareEnum.Editor,
                "Viewer" => ShareEnum.Viewer,
                _ => null,
            };
        }
    }
}