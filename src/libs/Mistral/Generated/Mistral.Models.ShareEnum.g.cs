
#nullable enable

namespace Mistral
{

    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ShareEnum : global::System.IEquatable<ShareEnum>
    {
        /// <summary>
        /// 
        /// </summary>
        public ShareEnum(string value)
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
        public static ShareEnum Editor { get; } = new("Editor");

        /// <summary>
        /// 
        /// </summary>
        public static ShareEnum Viewer { get; } = new("Viewer");
        /// <summary>
        /// 
        /// </summary>
        public static ShareEnum FromValue(string value)
        {
            value = value ?? throw new global::System.ArgumentNullException(nameof(value));

            return value switch
            {
                "Editor" => Editor,
                "Viewer" => Viewer,
                _ => new ShareEnum(value),
            };
        }

        /// <summary>
        /// 
        /// </summary>
        public bool IsKnown => Value switch
        {
            "Editor" => true,
            "Viewer" => true,
            _ => false,
        };

        /// <summary>
        /// 
        /// </summary>
        public override string ToString() => Value ?? string.Empty;

        /// <summary>
        /// 
        /// </summary>
        public bool Equals(ShareEnum other)
        {
            return string.Equals(Value, other.Value, global::System.StringComparison.Ordinal);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ShareEnum other && Equals(other);
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
        public static bool operator ==(ShareEnum left, ShareEnum right) => left.Equals(right);

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ShareEnum left, ShareEnum right) => !left.Equals(right);
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
            return value.Value ?? throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null);
        }

        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ShareEnum? ToEnum(string value)
        {
            return ShareEnum.FromValue(value);
        }
    }
}