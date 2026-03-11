
#nullable enable

namespace Mistral
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AudioFormat
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("encoding")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Mistral.JsonConverters.AudioEncodingJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public global::Mistral.AudioEncoding Encoding { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sample_rate")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public int SampleRate { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AudioFormat" /> class.
        /// </summary>
        /// <param name="encoding"></param>
        /// <param name="sampleRate"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AudioFormat(
            global::Mistral.AudioEncoding encoding,
            int sampleRate)
        {
            this.Encoding = encoding;
            this.SampleRate = sampleRate;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AudioFormat" /> class.
        /// </summary>
        public AudioFormat()
        {
        }
    }
}