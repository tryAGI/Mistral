
#nullable enable

namespace Mistral
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ListFilesOut
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Mistral.FileSchema> Data { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Object { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Total { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListFilesOut" /> class.
        /// </summary>
        /// <param name="data"></param>
        /// <param name="object"></param>
        /// <param name="total"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public ListFilesOut(
            global::System.Collections.Generic.IList<global::Mistral.FileSchema> data,
            string @object,
            int total)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.Object = @object ?? throw new global::System.ArgumentNullException(nameof(@object));
            this.Total = total;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListFilesOut" /> class.
        /// </summary>
        public ListFilesOut()
        {
        }
    }
}