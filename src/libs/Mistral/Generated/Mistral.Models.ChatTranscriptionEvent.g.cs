
#nullable enable

namespace Mistral
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatTranscriptionEvent
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AudioUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("response_message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object ResponseMessage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatTranscriptionEvent" /> class.
        /// </summary>
        /// <param name="audioUrl"></param>
        /// <param name="model"></param>
        /// <param name="responseMessage"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatTranscriptionEvent(
            string audioUrl,
            string model,
            object responseMessage)
        {
            this.AudioUrl = audioUrl ?? throw new global::System.ArgumentNullException(nameof(audioUrl));
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.ResponseMessage = responseMessage ?? throw new global::System.ArgumentNullException(nameof(responseMessage));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatTranscriptionEvent" /> class.
        /// </summary>
        public ChatTranscriptionEvent()
        {
        }
    }
}