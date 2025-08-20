
#nullable enable

namespace Mistral
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AudioTranscriptionRequestStream
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file")]
        public object? File { get; set; }

        /// <summary>
        /// ID of a file uploaded to /v1/files
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_id")]
        public string? FileId { get; set; }

        /// <summary>
        /// Url of a file to be transcribed
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_url")]
        public string? FileUrl { get; set; }

        /// <summary>
        /// Language of the audio, e.g. 'en'. Providing the language can boost accuracy.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language")]
        public string? Language { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; }

        /// <summary>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stream")]
        public bool? Stream { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("temperature")]
        public double? Temperature { get; set; }

        /// <summary>
        /// Granularities of timestamps to include in the response.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timestamp_granularities")]
        public global::System.Collections.Generic.IList<global::Mistral.TimestampGranularity>? TimestampGranularities { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AudioTranscriptionRequestStream" /> class.
        /// </summary>
        /// <param name="file"></param>
        /// <param name="fileId">
        /// ID of a file uploaded to /v1/files
        /// </param>
        /// <param name="fileUrl">
        /// Url of a file to be transcribed
        /// </param>
        /// <param name="language">
        /// Language of the audio, e.g. 'en'. Providing the language can boost accuracy.
        /// </param>
        /// <param name="model"></param>
        /// <param name="stream">
        /// Default Value: true
        /// </param>
        /// <param name="temperature"></param>
        /// <param name="timestampGranularities">
        /// Granularities of timestamps to include in the response.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AudioTranscriptionRequestStream(
            string model,
            object? file,
            string? fileId,
            string? fileUrl,
            string? language,
            bool? stream,
            double? temperature,
            global::System.Collections.Generic.IList<global::Mistral.TimestampGranularity>? timestampGranularities)
        {
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.File = file;
            this.FileId = fileId;
            this.FileUrl = fileUrl;
            this.Language = language;
            this.Stream = stream;
            this.Temperature = temperature;
            this.TimestampGranularities = timestampGranularities;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AudioTranscriptionRequestStream" /> class.
        /// </summary>
        public AudioTranscriptionRequestStream()
        {
        }
    }
}