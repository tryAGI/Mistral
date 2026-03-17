
#nullable enable

namespace Mistral
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PutDatasetRecordPropertiesInSchema
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("properties")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Properties { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PutDatasetRecordPropertiesInSchema" /> class.
        /// </summary>
        /// <param name="properties"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PutDatasetRecordPropertiesInSchema(
            object properties)
        {
            this.Properties = properties ?? throw new global::System.ArgumentNullException(nameof(properties));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PutDatasetRecordPropertiesInSchema" /> class.
        /// </summary>
        public PutDatasetRecordPropertiesInSchema()
        {
        }
    }
}