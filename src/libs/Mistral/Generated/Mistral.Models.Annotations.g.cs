
#nullable enable

namespace Mistral
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Annotations
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audience")]
        public global::System.Collections.Generic.IList<global::Mistral.AnnotationsAudienceVariant1Item>? Audience { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("priority")]
        public double? Priority { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Annotations" /> class.
        /// </summary>
        /// <param name="audience"></param>
        /// <param name="priority"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Annotations(
            global::System.Collections.Generic.IList<global::Mistral.AnnotationsAudienceVariant1Item>? audience,
            double? priority)
        {
            this.Audience = audience;
            this.Priority = priority;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Annotations" /> class.
        /// </summary>
        public Annotations()
        {
        }
    }
}