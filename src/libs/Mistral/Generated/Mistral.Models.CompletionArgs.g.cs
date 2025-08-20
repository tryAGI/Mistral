
#nullable enable

namespace Mistral
{
    /// <summary>
    /// White-listed arguments from the completion API
    /// </summary>
    public sealed partial class CompletionArgs
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("frequency_penalty")]
        public double? FrequencyPenalty { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_tokens")]
        public int? MaxTokens { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prediction")]
        public object? Prediction { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("presence_penalty")]
        public double? PresencePenalty { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("random_seed")]
        public int? RandomSeed { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("response_format")]
        public object? ResponseFormat { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stop")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Mistral.JsonConverters.CompletionArgsStopJsonConverter))]
        public global::Mistral.CompletionArgsStop? Stop { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("temperature")]
        public double? Temperature { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_choice")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Mistral.JsonConverters.ToolChoiceEnumJsonConverter))]
        public global::Mistral.ToolChoiceEnum? ToolChoice { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("top_p")]
        public double? TopP { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CompletionArgs" /> class.
        /// </summary>
        /// <param name="frequencyPenalty"></param>
        /// <param name="maxTokens"></param>
        /// <param name="prediction"></param>
        /// <param name="presencePenalty"></param>
        /// <param name="randomSeed"></param>
        /// <param name="responseFormat"></param>
        /// <param name="stop"></param>
        /// <param name="temperature"></param>
        /// <param name="toolChoice"></param>
        /// <param name="topP"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CompletionArgs(
            double? frequencyPenalty,
            int? maxTokens,
            object? prediction,
            double? presencePenalty,
            int? randomSeed,
            object? responseFormat,
            global::Mistral.CompletionArgsStop? stop,
            double? temperature,
            global::Mistral.ToolChoiceEnum? toolChoice,
            double? topP)
        {
            this.FrequencyPenalty = frequencyPenalty;
            this.MaxTokens = maxTokens;
            this.Prediction = prediction;
            this.PresencePenalty = presencePenalty;
            this.RandomSeed = randomSeed;
            this.ResponseFormat = responseFormat;
            this.Stop = stop;
            this.Temperature = temperature;
            this.ToolChoice = toolChoice;
            this.TopP = topP;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CompletionArgs" /> class.
        /// </summary>
        public CompletionArgs()
        {
        }
    }
}