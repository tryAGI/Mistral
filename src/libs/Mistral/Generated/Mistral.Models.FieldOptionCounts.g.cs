
#nullable enable

namespace Mistral
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FieldOptionCounts
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("counts")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Mistral.FieldOptionCountItem> Counts { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FieldOptionCounts" /> class.
        /// </summary>
        /// <param name="counts"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FieldOptionCounts(
            global::System.Collections.Generic.IList<global::Mistral.FieldOptionCountItem> counts)
        {
            this.Counts = counts ?? throw new global::System.ArgumentNullException(nameof(counts));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FieldOptionCounts" /> class.
        /// </summary>
        public FieldOptionCounts()
        {
        }
    }
}