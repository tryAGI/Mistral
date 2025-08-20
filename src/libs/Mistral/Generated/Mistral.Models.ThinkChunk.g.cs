
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Mistral
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ThinkChunk
    {
        /// <summary>
        /// Whether the thinking chunk is closed or not. Currently only used for prefixing.<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("closed")]
        public bool? Closed { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("thinking")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Mistral.AnyOf<global::Mistral.ReferenceChunk, global::Mistral.TextChunk>> Thinking { get; set; }

        /// <summary>
        /// Default Value: thinking
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Mistral.JsonConverters.ThinkChunkTypeJsonConverter))]
        public global::Mistral.ThinkChunkType? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ThinkChunk" /> class.
        /// </summary>
        /// <param name="closed">
        /// Whether the thinking chunk is closed or not. Currently only used for prefixing.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="thinking"></param>
        /// <param name="type">
        /// Default Value: thinking
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ThinkChunk(
            global::System.Collections.Generic.IList<global::Mistral.AnyOf<global::Mistral.ReferenceChunk, global::Mistral.TextChunk>> thinking,
            bool? closed,
            global::Mistral.ThinkChunkType? type)
        {
            this.Thinking = thinking ?? throw new global::System.ArgumentNullException(nameof(thinking));
            this.Closed = closed;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ThinkChunk" /> class.
        /// </summary>
        public ThinkChunk()
        {
        }
    }
}