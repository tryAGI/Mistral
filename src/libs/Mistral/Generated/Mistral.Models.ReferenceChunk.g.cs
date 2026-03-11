
#nullable enable

namespace Mistral
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ReferenceChunk
    {
        /// <summary>
        /// Default Value: reference
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reference_ids")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<int> ReferenceIds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ReferenceChunk" /> class.
        /// </summary>
        /// <param name="type">
        /// Default Value: reference
        /// </param>
        /// <param name="referenceIds"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ReferenceChunk(
            global::System.Collections.Generic.IList<int> referenceIds,
            string? type)
        {
            this.ReferenceIds = referenceIds ?? throw new global::System.ArgumentNullException(nameof(referenceIds));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReferenceChunk" /> class.
        /// </summary>
        public ReferenceChunk()
        {
        }
    }
}