
#nullable enable

namespace Mistral
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ToolConfiguration
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("exclude")]
        public global::System.Collections.Generic.IList<string>? Exclude { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("include")]
        public global::System.Collections.Generic.IList<string>? Include { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("requires_confirmation")]
        public global::System.Collections.Generic.IList<string>? RequiresConfirmation { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolConfiguration" /> class.
        /// </summary>
        /// <param name="exclude"></param>
        /// <param name="include"></param>
        /// <param name="requiresConfirmation"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ToolConfiguration(
            global::System.Collections.Generic.IList<string>? exclude,
            global::System.Collections.Generic.IList<string>? include,
            global::System.Collections.Generic.IList<string>? requiresConfirmation)
        {
            this.Exclude = exclude;
            this.Include = include;
            this.RequiresConfirmation = requiresConfirmation;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolConfiguration" /> class.
        /// </summary>
        public ToolConfiguration()
        {
        }
    }
}