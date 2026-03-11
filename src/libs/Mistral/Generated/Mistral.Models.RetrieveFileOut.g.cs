
#nullable enable

namespace Mistral
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RetrieveFileOut
    {
        /// <summary>
        /// The unique identifier of the file.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public global::System.Guid Id { get; set; } = default!;

        /// <summary>
        /// The object type, which is always "file".
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public string Object { get; set; } = default!;

        /// <summary>
        /// The size of the file, in bytes.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bytes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public int Bytes { get; set; } = default!;

        /// <summary>
        /// The UNIX timestamp (in seconds) of the event.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Mistral.JsonConverters.UnixTimestampJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public global::System.DateTimeOffset CreatedAt { get; set; } = default!;

        /// <summary>
        /// The name of the uploaded file.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filename")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public string Filename { get; set; } = default!;

        /// <summary>
        /// The intended purpose of the uploaded file, currently supports fine-tuning (`fine-tune`), OCR (`ocr`), Audio/Transcription (`audio`) and batch inference (`batch`).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("purpose")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Mistral.JsonConverters.FilePurposeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public global::Mistral.FilePurpose Purpose { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sample_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Mistral.JsonConverters.SampleTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public global::Mistral.SampleType SampleType { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("num_lines")]
        public int? NumLines { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mimetype")]
        public string? Mimetype { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Mistral.JsonConverters.SourceJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public global::Mistral.Source Source { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("signature")]
        public string? Signature { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deleted")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public bool Deleted { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RetrieveFileOut" /> class.
        /// </summary>
        /// <param name="id">
        /// The unique identifier of the file.
        /// </param>
        /// <param name="object">
        /// The object type, which is always "file".
        /// </param>
        /// <param name="bytes">
        /// The size of the file, in bytes.
        /// </param>
        /// <param name="createdAt">
        /// The UNIX timestamp (in seconds) of the event.
        /// </param>
        /// <param name="filename">
        /// The name of the uploaded file.
        /// </param>
        /// <param name="purpose">
        /// The intended purpose of the uploaded file, currently supports fine-tuning (`fine-tune`), OCR (`ocr`), Audio/Transcription (`audio`) and batch inference (`batch`).
        /// </param>
        /// <param name="sampleType"></param>
        /// <param name="numLines"></param>
        /// <param name="mimetype"></param>
        /// <param name="source"></param>
        /// <param name="signature"></param>
        /// <param name="deleted"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RetrieveFileOut(
            global::System.Guid id,
            string @object,
            int bytes,
            global::System.DateTimeOffset createdAt,
            string filename,
            global::Mistral.FilePurpose purpose,
            global::Mistral.SampleType sampleType,
            global::Mistral.Source source,
            bool deleted,
            int? numLines,
            string? mimetype,
            string? signature)
        {
            this.Id = id;
            this.Object = @object ?? throw new global::System.ArgumentNullException(nameof(@object));
            this.Bytes = bytes;
            this.CreatedAt = createdAt;
            this.Filename = filename ?? throw new global::System.ArgumentNullException(nameof(filename));
            this.Purpose = purpose;
            this.SampleType = sampleType;
            this.Source = source;
            this.Deleted = deleted;
            this.NumLines = numLines;
            this.Mimetype = mimetype;
            this.Signature = signature;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RetrieveFileOut" /> class.
        /// </summary>
        public RetrieveFileOut()
        {
        }
    }
}