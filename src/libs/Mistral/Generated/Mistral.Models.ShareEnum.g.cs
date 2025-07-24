
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
        Viewer,
        /// <summary>
        /// 
        /// </summary>
        Editor,
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
                ShareEnum.Viewer => "Viewer",
                ShareEnum.Editor => "Editor",
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
                "Viewer" => ShareEnum.Viewer,
                "Editor" => ShareEnum.Editor,
                _ => null,
            };
        }
    }
}