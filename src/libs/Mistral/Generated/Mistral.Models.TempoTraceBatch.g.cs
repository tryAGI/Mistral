
#nullable enable

namespace Mistral
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TempoTraceBatch
    {
        /// <summary>
        /// The resource of the batch
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resource")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Mistral.TempoTraceResource Resource { get; set; }

        /// <summary>
        /// The spans of the scope
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scopeSpans")]
        public global::System.Collections.Generic.IList<global::Mistral.TempoTraceScopeSpan>? ScopeSpans { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TempoTraceBatch" /> class.
        /// </summary>
        /// <param name="resource">
        /// The resource of the batch
        /// </param>
        /// <param name="scopeSpans">
        /// The spans of the scope
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TempoTraceBatch(
            global::Mistral.TempoTraceResource resource,
            global::System.Collections.Generic.IList<global::Mistral.TempoTraceScopeSpan>? scopeSpans)
        {
            this.Resource = resource ?? throw new global::System.ArgumentNullException(nameof(resource));
            this.ScopeSpans = scopeSpans;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TempoTraceBatch" /> class.
        /// </summary>
        public TempoTraceBatch()
        {
        }
    }
}