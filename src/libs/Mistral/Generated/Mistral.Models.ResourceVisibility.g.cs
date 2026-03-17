
#nullable enable

namespace Mistral
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResourceVisibility
    {
        /// <summary>
        /// 
        /// </summary>
        SharedGlobal,
        /// <summary>
        /// 
        /// </summary>
        SharedOrg,
        /// <summary>
        /// 
        /// </summary>
        SharedWorkspace,
        /// <summary>
        /// 
        /// </summary>
        Private,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResourceVisibilityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResourceVisibility value)
        {
            return value switch
            {
                ResourceVisibility.SharedGlobal => "shared_global",
                ResourceVisibility.SharedOrg => "shared_org",
                ResourceVisibility.SharedWorkspace => "shared_workspace",
                ResourceVisibility.Private => "private",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResourceVisibility? ToEnum(string value)
        {
            return value switch
            {
                "shared_global" => ResourceVisibility.SharedGlobal,
                "shared_org" => ResourceVisibility.SharedOrg,
                "shared_workspace" => ResourceVisibility.SharedWorkspace,
                "private" => ResourceVisibility.Private,
                _ => null,
            };
        }
    }
}