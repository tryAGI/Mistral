
#nullable enable

namespace Mistral
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CompletionDetailedJobOut
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public global::System.Guid Id { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("auto_start")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public bool AutoStart { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public string Model { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Mistral.JsonConverters.CompletionDetailedJobOutStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public global::Mistral.CompletionDetailedJobOutStatus Status { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public int CreatedAt { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("modified_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public int ModifiedAt { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("training_files")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public global::System.Collections.Generic.IList<global::System.Guid> TrainingFiles { get; set; } = default!;

        /// <summary>
        /// Default Value: []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("validation_files")]
        public global::System.Collections.Generic.IList<global::System.Guid>? ValidationFiles { get; set; }

        /// <summary>
        /// Default Value: job
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        public string? Object { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fine_tuned_model")]
        public string? FineTunedModel { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("suffix")]
        public string? Suffix { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("integrations")]
        public global::System.Collections.Generic.IList<global::Mistral.IntegrationsVariant1Item5>? Integrations { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("trained_tokens")]
        public int? TrainedTokens { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public global::Mistral.JobMetadataOut? Metadata { get; set; }

        /// <summary>
        /// Default Value: completion
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("job_type")]
        public string? JobType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hyperparameters")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public global::Mistral.CompletionTrainingParameters Hyperparameters { get; set; } = default!;

        /// <summary>
        /// Default Value: []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repositories")]
        public global::System.Collections.Generic.IList<global::Mistral.RepositoriesItem2>? Repositories { get; set; }

        /// <summary>
        /// Event items are created every time the status of a fine-tuning job changes. The timestamped list of all events is accessible here.<br/>
        /// Default Value: []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("events")]
        public global::System.Collections.Generic.IList<global::Mistral.EventOut>? Events { get; set; }

        /// <summary>
        /// Default Value: []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("checkpoints")]
        public global::System.Collections.Generic.IList<global::Mistral.CheckpointOut>? Checkpoints { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CompletionDetailedJobOut" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="autoStart"></param>
        /// <param name="model"></param>
        /// <param name="status"></param>
        /// <param name="createdAt"></param>
        /// <param name="modifiedAt"></param>
        /// <param name="trainingFiles"></param>
        /// <param name="validationFiles">
        /// Default Value: []
        /// </param>
        /// <param name="object">
        /// Default Value: job
        /// </param>
        /// <param name="fineTunedModel"></param>
        /// <param name="suffix"></param>
        /// <param name="integrations"></param>
        /// <param name="trainedTokens"></param>
        /// <param name="metadata"></param>
        /// <param name="jobType">
        /// Default Value: completion
        /// </param>
        /// <param name="hyperparameters"></param>
        /// <param name="repositories">
        /// Default Value: []
        /// </param>
        /// <param name="events">
        /// Event items are created every time the status of a fine-tuning job changes. The timestamped list of all events is accessible here.<br/>
        /// Default Value: []
        /// </param>
        /// <param name="checkpoints">
        /// Default Value: []
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CompletionDetailedJobOut(
            global::System.Guid id,
            bool autoStart,
            string model,
            global::Mistral.CompletionDetailedJobOutStatus status,
            int createdAt,
            int modifiedAt,
            global::System.Collections.Generic.IList<global::System.Guid> trainingFiles,
            global::Mistral.CompletionTrainingParameters hyperparameters,
            global::System.Collections.Generic.IList<global::System.Guid>? validationFiles,
            string? @object,
            string? fineTunedModel,
            string? suffix,
            global::System.Collections.Generic.IList<global::Mistral.IntegrationsVariant1Item5>? integrations,
            int? trainedTokens,
            global::Mistral.JobMetadataOut? metadata,
            string? jobType,
            global::System.Collections.Generic.IList<global::Mistral.RepositoriesItem2>? repositories,
            global::System.Collections.Generic.IList<global::Mistral.EventOut>? events,
            global::System.Collections.Generic.IList<global::Mistral.CheckpointOut>? checkpoints)
        {
            this.Id = id;
            this.AutoStart = autoStart;
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.Status = status;
            this.CreatedAt = createdAt;
            this.ModifiedAt = modifiedAt;
            this.TrainingFiles = trainingFiles ?? throw new global::System.ArgumentNullException(nameof(trainingFiles));
            this.Hyperparameters = hyperparameters ?? throw new global::System.ArgumentNullException(nameof(hyperparameters));
            this.ValidationFiles = validationFiles;
            this.Object = @object;
            this.FineTunedModel = fineTunedModel;
            this.Suffix = suffix;
            this.Integrations = integrations;
            this.TrainedTokens = trainedTokens;
            this.Metadata = metadata;
            this.JobType = jobType;
            this.Repositories = repositories;
            this.Events = events;
            this.Checkpoints = checkpoints;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CompletionDetailedJobOut" /> class.
        /// </summary>
        public CompletionDetailedJobOut()
        {
        }
    }
}