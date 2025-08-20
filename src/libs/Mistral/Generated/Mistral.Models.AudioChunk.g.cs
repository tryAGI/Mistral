
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Mistral
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AudioChunk
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_audio")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Mistral.JsonConverters.AnyOfJsonConverter<string, byte[]>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Mistral.AnyOf<string, byte[]> InputAudio { get; set; }

        /// <summary>
        /// Default Value: input_audio
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Mistral.JsonConverters.AudioChunkTypeJsonConverter))]
        public global::Mistral.AudioChunkType? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AudioChunk" /> class.
        /// </summary>
        /// <param name="inputAudio"></param>
        /// <param name="type">
        /// Default Value: input_audio
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AudioChunk(
            global::Mistral.AnyOf<string, byte[]> inputAudio,
            global::Mistral.AudioChunkType? type)
        {
            this.InputAudio = inputAudio;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AudioChunk" /> class.
        /// </summary>
        public AudioChunk()
        {
        }
    }
}