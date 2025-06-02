
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Mistral
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EmbeddingRequest
    {
        /// <summary>
        /// Text to embed.<br/>
        /// Example: Embed this sentence.
        /// </summary>
        /// <example>Embed this sentence.</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("input")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Mistral.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Mistral.AnyOf<string, global::System.Collections.Generic.IList<string>> Input { get; set; }

        /// <summary>
        /// ID of the model to use.<br/>
        /// Example: mistral-embed
        /// </summary>
        /// <example>mistral-embed</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; }

        /// <summary>
        /// The dimension of the output embeddings.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_dimension")]
        public int? OutputDimension { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_dtype")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Mistral.JsonConverters.EmbeddingDtypeJsonConverter))]
        public global::Mistral.EmbeddingDtype? OutputDtype { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EmbeddingRequest" /> class.
        /// </summary>
        /// <param name="input">
        /// Text to embed.<br/>
        /// Example: Embed this sentence.
        /// </param>
        /// <param name="model">
        /// ID of the model to use.<br/>
        /// Example: mistral-embed
        /// </param>
        /// <param name="outputDimension">
        /// The dimension of the output embeddings.
        /// </param>
        /// <param name="outputDtype"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EmbeddingRequest(
            global::Mistral.AnyOf<string, global::System.Collections.Generic.IList<string>> input,
            string model,
            int? outputDimension,
            global::Mistral.EmbeddingDtype? outputDtype)
        {
            this.Input = input;
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.OutputDimension = outputDimension;
            this.OutputDtype = outputDtype;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EmbeddingRequest" /> class.
        /// </summary>
        public EmbeddingRequest()
        {
        }
    }
}