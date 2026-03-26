
#nullable enable

namespace Mistral
{
    /// <summary>
    /// Request model for creating a new voice with base64 audio.
    /// </summary>
    public sealed partial class VoiceCreateRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("slug")]
        public string? Slug { get; set; }

        /// <summary>
        /// Default Value: []
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
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("color")]
        public string? Color { get; set; }

        /// <summary>
        /// Default Value: 30
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("retention_notice")]
        public int? RetentionNotice { get; set; }

        /// <summary>
        /// Base64-encoded audio file
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sample_audio")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SampleAudio { get; set; }

        /// <summary>
        /// Original filename for extension detection
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sample_filename")]
        public string? SampleFilename { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VoiceCreateRequest" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="slug"></param>
        /// <param name="languages">
        /// Default Value: []
        /// </param>
        /// <param name="gender"></param>
        /// <param name="age"></param>
        /// <param name="tags"></param>
        /// <param name="color"></param>
        /// <param name="retentionNotice">
        /// Default Value: 30
        /// </param>
        /// <param name="sampleAudio">
        /// Base64-encoded audio file
        /// </param>
        /// <param name="sampleFilename">
        /// Original filename for extension detection
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VoiceCreateRequest(
            string name,
            string sampleAudio,
            string? slug,
            global::System.Collections.Generic.IList<string>? languages,
            string? gender,
            int? age,
            global::System.Collections.Generic.IList<string>? tags,
            string? color,
            int? retentionNotice,
            string? sampleFilename)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.SampleAudio = sampleAudio ?? throw new global::System.ArgumentNullException(nameof(sampleAudio));
            this.Slug = slug;
            this.Languages = languages;
            this.Gender = gender;
            this.Age = age;
            this.Tags = tags;
            this.Color = color;
            this.RetentionNotice = retentionNotice;
            this.SampleFilename = sampleFilename;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VoiceCreateRequest" /> class.
        /// </summary>
        public VoiceCreateRequest()
        {
        }
    }
}