
#nullable enable

namespace Mistral
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EmbeddingRequest
    {
        /// <summary>
        /// ID of the model to use.<br/>
        /// Example: mistral-embed
        /// </summary>
        /// <example>mistral-embed</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// Text to embed.<br/>
        /// Example: [Embed this sentence., As well as this one.]
        /// </summary>
        /// <example>[Embed this sentence., As well as this one.]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("input")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Mistral.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Mistral.AnyOf<string, global::System.Collections.Generic.IList<string>> Input { get; set; }

        /// <summary>
        /// The dimension of the output embeddings when feature available. If not provided, a default output dimension will be used.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_dimension")]
        public int? OutputDimension { get; set; }

        /// <summary>
        /// The data type of the output embeddings when feature available. If not provided, a default output data type will be used.<br/>
        /// Default Value: float
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_dtype")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Mistral.JsonConverters.EmbeddingDtypeJsonConverter))]
        public global::Mistral.EmbeddingDtype? OutputDtype { get; set; }

        /// <summary>
        /// The format of embeddings in the response.<br/>
        /// Default Value: float
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("encoding_format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Mistral.JsonConverters.EncodingFormatJsonConverter))]
        public global::Mistral.EncodingFormat? EncodingFormat { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EmbeddingRequest" /> class.
        /// </summary>
        /// <param name="model">
        /// ID of the model to use.<br/>
        /// Example: mistral-embed
        /// </param>
        /// <param name="input">
        /// Text to embed.<br/>
        /// Example: [Embed this sentence., As well as this one.]
        /// </param>
        /// <param name="metadata"></param>
        /// <param name="outputDimension">
        /// The dimension of the output embeddings when feature available. If not provided, a default output dimension will be used.
        /// </param>
        /// <param name="outputDtype">
        /// The data type of the output embeddings when feature available. If not provided, a default output data type will be used.<br/>
        /// Default Value: float
        /// </param>
        /// <param name="encodingFormat">
        /// The format of embeddings in the response.<br/>
        /// Default Value: float
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EmbeddingRequest(
            string model,
            global::Mistral.AnyOf<string, global::System.Collections.Generic.IList<string>> input,
            object? metadata,
            int? outputDimension,
            global::Mistral.EmbeddingDtype? outputDtype,
            global::Mistral.EncodingFormat? encodingFormat)
        {
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.Metadata = metadata;
            this.Input = input;
            this.OutputDimension = outputDimension;
            this.OutputDtype = outputDtype;
            this.EncodingFormat = encodingFormat;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EmbeddingRequest" /> class.
        /// </summary>
        public EmbeddingRequest()
        {
        }
    }
}