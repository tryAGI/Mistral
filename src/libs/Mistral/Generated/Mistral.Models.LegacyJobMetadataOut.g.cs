
#nullable enable

namespace Mistral
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LegacyJobMetadataOut
    {
        /// <summary>
        /// The cost of the fine-tuning job.<br/>
        /// Example: 10
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cost")]
        public double? Cost { get; set; }

        /// <summary>
        /// The currency used for the fine-tuning job cost.<br/>
        /// Example: EUR
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cost_currency")]
        public string? CostCurrency { get; set; }

        /// <summary>
        /// The total number of tokens in the training dataset.<br/>
        /// Example: 305375
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data_tokens")]
        public int? DataTokens { get; set; }

        /// <summary>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deprecated")]
        public bool? Deprecated { get; set; } = true;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("details")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Details { get; set; }

        /// <summary>
        /// The number of complete passes through the entire training dataset.<br/>
        /// Example: 4.2922
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("epochs")]
        public double? Epochs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("estimated_start_time")]
        public int? EstimatedStartTime { get; set; }

        /// <summary>
        /// The approximated time (in seconds) for the fine-tuning process to complete.<br/>
        /// Example: 220
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expected_duration_seconds")]
        public int? ExpectedDurationSeconds { get; set; }

        /// <summary>
        /// Default Value: job.metadata
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Mistral.JsonConverters.LegacyJobMetadataOutObjectJsonConverter))]
        public global::Mistral.LegacyJobMetadataOutObject? Object { get; set; } = global::Mistral.LegacyJobMetadataOutObject.JobMetadata;

        /// <summary>
        /// The total number of tokens used during the fine-tuning process.<br/>
        /// Example: 1310720
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("train_tokens")]
        public int? TrainTokens { get; set; }

        /// <summary>
        /// The number of tokens consumed by one training step.<br/>
        /// Example: 131072
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("train_tokens_per_step")]
        public int? TrainTokensPerStep { get; set; }

        /// <summary>
        /// The number of training steps to perform. A training step refers to a single update of the model weights during the fine-tuning process. This update is typically calculated using a batch of samples from the training dataset.<br/>
        /// Example: 10
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("training_steps")]
        public int? TrainingSteps { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}