
#nullable enable

namespace Mistral
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FilterGroup
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("AND")]
        public global::System.Collections.Generic.IList<global::Mistral.AnyOf<global::Mistral.FilterGroup, global::Mistral.FilterCondition>>? And { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("OR")]
        public global::System.Collections.Generic.IList<global::Mistral.AnyOf<global::Mistral.FilterGroup, global::Mistral.FilterCondition>>? Or { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FilterGroup" /> class.
        /// </summary>
        /// <param name="and"></param>
        /// <param name="or"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FilterGroup(
            global::System.Collections.Generic.IList<global::Mistral.AnyOf<global::Mistral.FilterGroup, global::Mistral.FilterCondition>>? and,
            global::System.Collections.Generic.IList<global::Mistral.AnyOf<global::Mistral.FilterGroup, global::Mistral.FilterCondition>>? or)
        {
            this.And = and;
            this.Or = or;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FilterGroup" /> class.
        /// </summary>
        public FilterGroup()
        {
        }
    }
}