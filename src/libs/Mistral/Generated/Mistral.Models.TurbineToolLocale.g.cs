
#nullable enable

namespace Mistral
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TurbineToolLocale
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public global::System.Collections.Generic.Dictionary<string, string>? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public global::System.Collections.Generic.Dictionary<string, string>? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("usage_sentence")]
        public global::System.Collections.Generic.Dictionary<string, string>? UsageSentence { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("working_description")]
        public global::System.Collections.Generic.Dictionary<string, string>? WorkingDescription { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("done_description")]
        public global::System.Collections.Generic.Dictionary<string, string>? DoneDescription { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TurbineToolLocale" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="usageSentence"></param>
        /// <param name="workingDescription"></param>
        /// <param name="doneDescription"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TurbineToolLocale(
            global::System.Collections.Generic.Dictionary<string, string>? name,
            global::System.Collections.Generic.Dictionary<string, string>? description,
            global::System.Collections.Generic.Dictionary<string, string>? usageSentence,
            global::System.Collections.Generic.Dictionary<string, string>? workingDescription,
            global::System.Collections.Generic.Dictionary<string, string>? doneDescription)
        {
            this.Name = name;
            this.Description = description;
            this.UsageSentence = usageSentence;
            this.WorkingDescription = workingDescription;
            this.DoneDescription = doneDescription;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TurbineToolLocale" /> class.
        /// </summary>
        public TurbineToolLocale()
        {
        }
    }
}