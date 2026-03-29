
#nullable enable

namespace Mistral
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SpeechRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string? Model { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stream")]
        public bool? Stream { get; set; }

        /// <summary>
        /// The preset or custom voice to use for generating the speech.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voice_id")]
        public string? VoiceId { get; set; }

        /// <summary>
        /// The base64-encoded audio reference for zero-shot voice cloning.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ref_audio")]
        public string? RefAudio { get; set; }

        /// <summary>
        /// Text to generate speech from.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Input { get; set; }

        /// <summary>
        /// Output audio format. Defaults to mp3.<br/>
        /// Default Value: mp3
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("response_format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Mistral.JsonConverters.SpeechOutputFormatJsonConverter))]
        public global::Mistral.SpeechOutputFormat? ResponseFormat { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SpeechRequest" /> class.
        /// </summary>
        /// <param name="input">
        /// Text to generate speech from.
        /// </param>
        /// <param name="model"></param>
        /// <param name="stream">
        /// Default Value: false
        /// </param>
        /// <param name="voiceId">
        /// The preset or custom voice to use for generating the speech.
        /// </param>
        /// <param name="refAudio">
        /// The base64-encoded audio reference for zero-shot voice cloning.
        /// </param>
        /// <param name="responseFormat">
        /// Output audio format. Defaults to mp3.<br/>
        /// Default Value: mp3
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SpeechRequest(
            string input,
            string? model,
            bool? stream,
            string? voiceId,
            string? refAudio,
            global::Mistral.SpeechOutputFormat? responseFormat)
        {
            this.Model = model;
            this.Stream = stream;
            this.VoiceId = voiceId;
            this.RefAudio = refAudio;
            this.Input = input ?? throw new global::System.ArgumentNullException(nameof(input));
            this.ResponseFormat = responseFormat;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SpeechRequest" /> class.
        /// </summary>
        public SpeechRequest()
        {
        }
    }
}