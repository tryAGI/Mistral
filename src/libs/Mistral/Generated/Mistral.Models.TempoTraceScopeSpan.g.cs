
#nullable enable

namespace Mistral
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TempoTraceScopeSpan
    {
        /// <summary>
        /// The scope of the span
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scope")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Mistral.TempoTraceScope Scope { get; set; }

        /// <summary>
        /// The spans of the scope
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("spans")]
        public global::System.Collections.Generic.IList<global::Mistral.TempoTraceSpan>? Spans { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TempoTraceScopeSpan" /> class.
        /// </summary>
        /// <param name="scope">
        /// The scope of the span
        /// </param>
        /// <param name="spans">
        /// The spans of the scope
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TempoTraceScopeSpan(
            global::Mistral.TempoTraceScope scope,
            global::System.Collections.Generic.IList<global::Mistral.TempoTraceSpan>? spans)
        {
            this.Scope = scope ?? throw new global::System.ArgumentNullException(nameof(scope));
            this.Spans = spans;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TempoTraceScopeSpan" /> class.
        /// </summary>
        public TempoTraceScopeSpan()
        {
        }
    }
}