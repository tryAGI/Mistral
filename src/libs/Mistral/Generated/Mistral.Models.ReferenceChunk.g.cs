
#nullable enable

namespace Mistral
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ReferenceChunk
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reference_ids")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<int> ReferenceIds { get; set; }

        /// <summary>
        /// Default Value: reference
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Mistral.JsonConverters.ReferenceChunkTypeJsonConverter))]
        public global::Mistral.ReferenceChunkType? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ReferenceChunk" /> class.
        /// </summary>
        /// <param name="referenceIds"></param>
        /// <param name="type">
        /// Default Value: reference
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public ReferenceChunk(
            global::System.Collections.Generic.IList<int> referenceIds,
            global::Mistral.ReferenceChunkType? type)
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