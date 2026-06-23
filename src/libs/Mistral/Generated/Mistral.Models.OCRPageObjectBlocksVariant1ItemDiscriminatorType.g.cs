
#nullable enable

namespace Mistral
{
    /// <summary>
    /// 
    /// </summary>
    public enum OCRPageObjectBlocksVariant1ItemDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        AsideText,
        /// <summary>
        /// 
        /// </summary>
        Caption,
        /// <summary>
        /// 
        /// </summary>
        Code,
        /// <summary>
        /// 
        /// </summary>
        Equation,
        /// <summary>
        /// 
        /// </summary>
        Footer,
        /// <summary>
        /// 
        /// </summary>
        Header,
        /// <summary>
        /// 
        /// </summary>
        Image,
        /// <summary>
        /// 
        /// </summary>
        List,
        /// <summary>
        /// 
        /// </summary>
        References,
        /// <summary>
        /// 
        /// </summary>
        Signature,
        /// <summary>
        /// 
        /// </summary>
        Table,
        /// <summary>
        /// 
        /// </summary>
        Text,
        /// <summary>
        /// 
        /// </summary>
        Title,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OCRPageObjectBlocksVariant1ItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OCRPageObjectBlocksVariant1ItemDiscriminatorType value)
        {
            return value switch
            {
                OCRPageObjectBlocksVariant1ItemDiscriminatorType.AsideText => "aside_text",
                OCRPageObjectBlocksVariant1ItemDiscriminatorType.Caption => "caption",
                OCRPageObjectBlocksVariant1ItemDiscriminatorType.Code => "code",
                OCRPageObjectBlocksVariant1ItemDiscriminatorType.Equation => "equation",
                OCRPageObjectBlocksVariant1ItemDiscriminatorType.Footer => "footer",
                OCRPageObjectBlocksVariant1ItemDiscriminatorType.Header => "header",
                OCRPageObjectBlocksVariant1ItemDiscriminatorType.Image => "image",
                OCRPageObjectBlocksVariant1ItemDiscriminatorType.List => "list",
                OCRPageObjectBlocksVariant1ItemDiscriminatorType.References => "references",
                OCRPageObjectBlocksVariant1ItemDiscriminatorType.Signature => "signature",
                OCRPageObjectBlocksVariant1ItemDiscriminatorType.Table => "table",
                OCRPageObjectBlocksVariant1ItemDiscriminatorType.Text => "text",
                OCRPageObjectBlocksVariant1ItemDiscriminatorType.Title => "title",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OCRPageObjectBlocksVariant1ItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "aside_text" => OCRPageObjectBlocksVariant1ItemDiscriminatorType.AsideText,
                "caption" => OCRPageObjectBlocksVariant1ItemDiscriminatorType.Caption,
                "code" => OCRPageObjectBlocksVariant1ItemDiscriminatorType.Code,
                "equation" => OCRPageObjectBlocksVariant1ItemDiscriminatorType.Equation,
                "footer" => OCRPageObjectBlocksVariant1ItemDiscriminatorType.Footer,
                "header" => OCRPageObjectBlocksVariant1ItemDiscriminatorType.Header,
                "image" => OCRPageObjectBlocksVariant1ItemDiscriminatorType.Image,
                "list" => OCRPageObjectBlocksVariant1ItemDiscriminatorType.List,
                "references" => OCRPageObjectBlocksVariant1ItemDiscriminatorType.References,
                "signature" => OCRPageObjectBlocksVariant1ItemDiscriminatorType.Signature,
                "table" => OCRPageObjectBlocksVariant1ItemDiscriminatorType.Table,
                "text" => OCRPageObjectBlocksVariant1ItemDiscriminatorType.Text,
                "title" => OCRPageObjectBlocksVariant1ItemDiscriminatorType.Title,
                _ => null,
            };
        }
    }
}