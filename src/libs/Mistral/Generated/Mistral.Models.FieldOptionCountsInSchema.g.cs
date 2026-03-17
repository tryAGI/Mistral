
#nullable enable

namespace Mistral
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FieldOptionCountsInSchema
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filter_params")]
        public global::Mistral.FilterPayload? FilterParams { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FieldOptionCountsInSchema" /> class.
        /// </summary>
        /// <param name="filterParams"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FieldOptionCountsInSchema(
            global::Mistral.FilterPayload? filterParams)
        {
            this.FilterParams = filterParams;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FieldOptionCountsInSchema" /> class.
        /// </summary>
        public FieldOptionCountsInSchema()
        {
        }
    }
}