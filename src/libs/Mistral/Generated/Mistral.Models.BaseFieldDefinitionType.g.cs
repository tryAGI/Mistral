
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
        Array,
        /// <summary>
        /// 
        /// </summary>
        Bool,
        /// <summary>
        /// 
        /// </summary>
        Enum,
        /// <summary>
        /// 
        /// </summary>
        Float,
        /// <summary>
        /// 
        /// </summary>
        Int,
        /// <summary>
        /// 
        /// </summary>
        Text,
        /// <summary>
        /// 
        /// </summary>
        Timestamp,
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
                BaseFieldDefinitionType.Array => "ARRAY",
                BaseFieldDefinitionType.Bool => "BOOL",
                BaseFieldDefinitionType.Enum => "ENUM",
                BaseFieldDefinitionType.Float => "FLOAT",
                BaseFieldDefinitionType.Int => "INT",
                BaseFieldDefinitionType.Text => "TEXT",
                BaseFieldDefinitionType.Timestamp => "TIMESTAMP",
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
                "ARRAY" => BaseFieldDefinitionType.Array,
                "BOOL" => BaseFieldDefinitionType.Bool,
                "ENUM" => BaseFieldDefinitionType.Enum,
                "FLOAT" => BaseFieldDefinitionType.Float,
                "INT" => BaseFieldDefinitionType.Int,
                "TEXT" => BaseFieldDefinitionType.Text,
                "TIMESTAMP" => BaseFieldDefinitionType.Timestamp,
                _ => null,
            };
        }
    }
}