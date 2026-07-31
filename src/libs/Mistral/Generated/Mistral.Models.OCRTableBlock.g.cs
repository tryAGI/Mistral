
#nullable enable

namespace Mistral
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OCRTableBlock
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("top_left_x")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TopLeftX { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("top_left_y")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TopLeftY { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bottom_right_x")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int BottomRightX { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bottom_right_y")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int BottomRightY { get; set; }

        /// <summary>
        /// Text/markdown/html content of this block
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Content { get; set; }

        /// <summary>
        /// Default Value: table
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// References the corresponding entry in OCRPageObject.tables, when tables are extracted
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("table_id")]
        public string? TableId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OCRTableBlock" /> class.
        /// </summary>
        /// <param name="topLeftX"></param>
        /// <param name="topLeftY"></param>
        /// <param name="bottomRightX"></param>
        /// <param name="bottomRightY"></param>
        /// <param name="content">
        /// Text/markdown/html content of this block
        /// </param>
        /// <param name="type">
        /// Default Value: table
        /// </param>
        /// <param name="tableId">
        /// References the corresponding entry in OCRPageObject.tables, when tables are extracted
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OCRTableBlock(
            int topLeftX,
            int topLeftY,
            int bottomRightX,
            int bottomRightY,
            string content,
            string? type,
            string? tableId)
        {
            this.TopLeftX = topLeftX;
            this.TopLeftY = topLeftY;
            this.BottomRightX = bottomRightX;
            this.BottomRightY = bottomRightY;
            this.Content = content ?? throw new global::System.ArgumentNullException(nameof(content));
            this.Type = type;
            this.TableId = tableId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OCRTableBlock" /> class.
        /// </summary>
        public OCRTableBlock()
        {
        }

    }
}