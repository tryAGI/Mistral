
#nullable enable

namespace Mistral
{
    /// <summary>
    /// 
    /// </summary>
    public enum BaseFieldDefinitionType
    {
        /// <summary>
        /// 
        /// </summary>
        Enum,
        /// <summary>
        /// 
        /// </summary>
        Text,
        /// <summary>
        /// 
        /// </summary>
        Int,
        /// <summary>
        /// 
        /// </summary>
        Float,
        /// <summary>
        /// 
        /// </summary>
        Bool,
        /// <summary>
        /// 
        /// </summary>
        Timestamp,
        /// <summary>
        /// 
        /// </summary>
        Array,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BaseFieldDefinitionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BaseFieldDefinitionType value)
        {
            return value switch
            {
                BaseFieldDefinitionType.Enum => "ENUM",
                BaseFieldDefinitionType.Text => "TEXT",
                BaseFieldDefinitionType.Int => "INT",
                BaseFieldDefinitionType.Float => "FLOAT",
                BaseFieldDefinitionType.Bool => "BOOL",
                BaseFieldDefinitionType.Timestamp => "TIMESTAMP",
                BaseFieldDefinitionType.Array => "ARRAY",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BaseFieldDefinitionType? ToEnum(string value)
        {
            return value switch
            {
                "ENUM" => BaseFieldDefinitionType.Enum,
                "TEXT" => BaseFieldDefinitionType.Text,
                "INT" => BaseFieldDefinitionType.Int,
                "FLOAT" => BaseFieldDefinitionType.Float,
                "BOOL" => BaseFieldDefinitionType.Bool,
                "TIMESTAMP" => BaseFieldDefinitionType.Timestamp,
                "ARRAY" => BaseFieldDefinitionType.Array,
                _ => null,
            };
        }
    }
}