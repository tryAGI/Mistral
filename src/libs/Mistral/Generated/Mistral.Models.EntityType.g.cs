
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
        Org,
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
    public static class EntityTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EntityType value)
        {
            return value switch
            {
                EntityType.Org => "Org",
                EntityType.User => "User",
                EntityType.Workspace => "Workspace",
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
                "Org" => EntityType.Org,
                "User" => EntityType.User,
                "Workspace" => EntityType.Workspace,
                _ => null,
            };
        }
    }
}