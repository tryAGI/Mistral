
#nullable enable

namespace Mistral
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TranscriptionStreamDone
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public string Model { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public string Text { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language")]
        public string? Language { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("segments")]
        public global::System.Collections.Generic.IList<global::Mistral.TranscriptionSegmentChunk>? Segments { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("usage")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public global::Mistral.UsageInfo Usage { get; set; } = default!;

        /// <summary>
        /// Default Value: transcription.done
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TranscriptionStreamDone" /> class.
        /// </summary>
        /// <param name="model"></param>
        /// <param name="text"></param>
        /// <param name="language"></param>
        /// <param name="segments"></param>
        /// <param name="usage"></param>
        /// <param name="type">
        /// Default Value: transcription.done
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TranscriptionStreamDone(
            string model,
            string text,
            global::Mistral.UsageInfo usage,
            string? language,
            global::System.Collections.Generic.IList<global::Mistral.TranscriptionSegmentChunk>? segments,
            string? type)
        {
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.Usage = usage ?? throw new global::System.ArgumentNullException(nameof(usage));
            this.Language = language;
            this.Segments = segments;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TranscriptionStreamDone" /> class.
        /// </summary>
        public TranscriptionStreamDone()
        {
        }
    }
}