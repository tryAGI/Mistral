
#nullable enable

namespace Mistral
{
    /// <summary>
    /// The type of entity, used to share a library.
    /// </summary>
    public enum EntityType
    {
        /// <summary>
        /// 
        /// </summary>
        User,
        /// <summary>
        /// 
        /// </summary>
        Workspace,
        /// <summary>
        /// 
        /// </summary>
        Org,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EntityTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EntityType value)
        {
            return value switch
            {
                EntityType.User => "User",
                EntityType.Workspace => "Workspace",
                EntityType.Org => "Org",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EntityType? ToEnum(string value)
        {
            return value switch
            {
                "User" => EntityType.User,
                "Workspace" => EntityType.Workspace,
                "Org" => EntityType.Org,
                _ => null,
            };
        }
    }
}