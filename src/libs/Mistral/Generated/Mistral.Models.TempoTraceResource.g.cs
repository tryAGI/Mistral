
#nullable enable

namespace Mistral
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TempoTraceResource
    {
        /// <summary>
        /// The attributes of the resource
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("attributes")]
        public global::System.Collections.Generic.IList<global::Mistral.TempoTraceAttribute>? Attributes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TempoTraceResource" /> class.
        /// </summary>
        /// <param name="attributes">
        /// The attributes of the resource
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TempoTraceResource(
            global::System.Collections.Generic.IList<global::Mistral.TempoTraceAttribute>? attributes)
        {
            this.Attributes = attributes;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TempoTraceResource" /> class.
        /// </summary>
        public TempoTraceResource()
        {
        }
    }
}