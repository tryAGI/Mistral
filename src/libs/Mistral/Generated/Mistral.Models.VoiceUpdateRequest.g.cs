
#nullable enable

namespace Mistral
{
    /// <summary>
    /// Request model for partially updating voice metadata.
    /// </summary>
    public sealed partial class VoiceUpdateRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("languages")]
        public global::System.Collections.Generic.IList<string>? Languages { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gender")]
        public string? Gender { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("age")]
        public int? Age { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tags")]
        public global::System.Collections.Generic.IList<string>? Tags { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VoiceUpdateRequest" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="languages"></param>
        /// <param name="gender"></param>
        /// <param name="age"></param>
        /// <param name="tags"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VoiceUpdateRequest(
            string? name,
            global::System.Collections.Generic.IList<string>? languages,
            string? gender,
            int? age,
            global::System.Collections.Generic.IList<string>? tags)
        {
            this.Name = name;
            this.Languages = languages;
            this.Gender = gender;
            this.Age = age;
            this.Tags = tags;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VoiceUpdateRequest" /> class.
        /// </summary>
        public VoiceUpdateRequest()
        {
        }
    }
}