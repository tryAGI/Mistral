
#nullable enable

namespace Mistral
{

    /// <summary>
    /// The type of entity, used to share a library.
    /// </summary>
    public readonly partial struct EntityType : global::System.IEquatable<EntityType>
    {
        /// <summary>
        /// 
        /// </summary>
        public EntityType(string value)
        {
            Value = value ?? throw new global::System.ArgumentNullException(nameof(value));
        }

        /// <summary>
        /// 
        /// </summary>
        public string Value { get; }
        /// <summary>
        /// 
        /// </summary>
        public static EntityType Org { get; } = new("Org");

        /// <summary>
        /// 
        /// </summary>
        public static EntityType User { get; } = new("User");

        /// <summary>
        /// 
        /// </summary>
        public static EntityType Workspace { get; } = new("Workspace");
        /// <summary>
        /// 
        /// </summary>
        public static EntityType FromValue(string value)
        {
            value = value ?? throw new global::System.ArgumentNullException(nameof(value));

            return value switch
            {
                "Org" => Org,
                "User" => User,
                "Workspace" => Workspace,
                _ => new EntityType(value),
            };
        }

        /// <summary>
        /// 
        /// </summary>
        public bool IsKnown => Value switch
        {
            "Org" => true,
            "User" => true,
            "Workspace" => true,
            _ => false,
        };

        /// <summary>
        /// 
        /// </summary>
        public override string ToString() => Value ?? string.Empty;

        /// <summary>
        /// 
        /// </summary>
        public bool Equals(EntityType other)
        {
            return string.Equals(Value, other.Value, global::System.StringComparison.Ordinal);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is EntityType other && Equals(other);
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            return global::System.StringComparer.Ordinal.GetHashCode(Value ?? string.Empty);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(EntityType left, EntityType right) => left.Equals(right);

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(EntityType left, EntityType right) => !left.Equals(right);
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
            return value.Value ?? throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null);
        }

        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EntityType? ToEnum(string value)
        {
            return EntityType.FromValue(value);
        }
    }
}