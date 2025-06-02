
#nullable enable

namespace Mistral
{
    /// <summary>
    /// 
    /// </summary>
    public enum EmbeddingDtype
    {
        /// <summary>
        /// 
        /// </summary>
        Float,
        /// <summary>
        /// 
        /// </summary>
        Int8,
        /// <summary>
        /// 
        /// </summary>
        Uint8,
        /// <summary>
        /// 
        /// </summary>
        Binary,
        /// <summary>
        /// 
        /// </summary>
        Ubinary,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EmbeddingDtypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EmbeddingDtype value)
        {
            return value switch
            {
                EmbeddingDtype.Float => "float",
                EmbeddingDtype.Int8 => "int8",
                EmbeddingDtype.Uint8 => "uint8",
                EmbeddingDtype.Binary => "binary",
                EmbeddingDtype.Ubinary => "ubinary",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EmbeddingDtype? ToEnum(string value)
        {
            return value switch
            {
                "float" => EmbeddingDtype.Float,
                "int8" => EmbeddingDtype.Int8,
                "uint8" => EmbeddingDtype.Uint8,
                "binary" => EmbeddingDtype.Binary,
                "ubinary" => EmbeddingDtype.Ubinary,
                _ => null,
            };
        }
    }
}