
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
        /// Default Value: thinking
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("thinking")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Mistral.AnyOf<global::Mistral.TextChunk, global::Mistral.ToolReferenceChunk, global::Mistral.ReferenceChunk>> Thinking { get; set; }

        /// <summary>
        /// Whether the thinking chunk is closed or not. Currently only used for prefixing.<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("closed")]
        public bool? Closed { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ThinkChunk" /> class.
        /// </summary>
        /// <param name="type">
        /// Default Value: thinking
        /// </param>
        /// <param name="thinking"></param>
        /// <param name="closed">
        /// Whether the thinking chunk is closed or not. Currently only used for prefixing.<br/>
        /// Default Value: true
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ThinkChunk(
            global::System.Collections.Generic.IList<global::Mistral.AnyOf<global::Mistral.TextChunk, global::Mistral.ToolReferenceChunk, global::Mistral.ReferenceChunk>> thinking,
            string? type,
            bool? closed)
        {
            this.Thinking = thinking ?? throw new global::System.ArgumentNullException(nameof(thinking));
            this.Type = type;
            this.Closed = closed;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ThinkChunk" /> class.
        /// </summary>
        public ThinkChunk()
        {
        }
    }
}