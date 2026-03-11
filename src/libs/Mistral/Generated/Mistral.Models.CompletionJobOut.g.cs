
#nullable enable

namespace Mistral
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CompletionJobOut
    {
        /// <summary>
        /// The ID of the job.
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
        /// The current status of the fine-tuning job.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Mistral.JsonConverters.CompletionJobOutStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public global::Mistral.CompletionJobOutStatus Status { get; set; } = default!;

        /// <summary>
        /// The UNIX timestamp (in seconds) for when the fine-tuning job was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Mistral.JsonConverters.UnixTimestampJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public global::System.DateTimeOffset CreatedAt { get; set; } = default!;

        /// <summary>
        /// The UNIX timestamp (in seconds) for when the fine-tuning job was last modified.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("modified_at")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Mistral.JsonConverters.UnixTimestampJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public global::System.DateTimeOffset ModifiedAt { get; set; } = default!;

        /// <summary>
        /// A list containing the IDs of uploaded files that contain training data.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("training_files")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public global::System.Collections.Generic.IList<global::System.Guid> TrainingFiles { get; set; } = default!;

        /// <summary>
        /// A list containing the IDs of uploaded files that contain validation data.<br/>
        /// Default Value: []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("validation_files")]
        public global::System.Collections.Generic.IList<global::System.Guid>? ValidationFiles { get; set; }

        /// <summary>
        /// The object type of the fine-tuning job.<br/>
        /// Default Value: job
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        public string? Object { get; set; }

        /// <summary>
        /// The name of the fine-tuned model that is being created. The value will be `null` if the fine-tuning job is still running.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fine_tuned_model")]
        public string? FineTunedModel { get; set; }

        /// <summary>
        /// Optional text/code that adds more context for the model. When given a `prompt` and a `suffix` the model will fill what is between them. When `suffix` is not provided, the model will simply execute completion starting with `prompt`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("suffix")]
        public string? Suffix { get; set; }

        /// <summary>
        /// A list of integrations enabled for your fine-tuning job.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("integrations")]
        public global::System.Collections.Generic.IList<global::Mistral.IntegrationsVariant1Item2>? Integrations { get; set; }

        /// <summary>
        /// Total number of tokens trained.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("trained_tokens")]
        public int? TrainedTokens { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public global::Mistral.JobMetadataOut? Metadata { get; set; }

        /// <summary>
        /// The type of job (`FT` for fine-tuning).<br/>
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
        public global::System.Collections.Generic.IList<global::Mistral.RepositoriesItem>? Repositories { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CompletionJobOut" /> class.
        /// </summary>
        /// <param name="id">
        /// The ID of the job.
        /// </param>
        /// <param name="autoStart"></param>
        /// <param name="model"></param>
        /// <param name="status">
        /// The current status of the fine-tuning job.
        /// </param>
        /// <param name="createdAt">
        /// The UNIX timestamp (in seconds) for when the fine-tuning job was created.
        /// </param>
        /// <param name="modifiedAt">
        /// The UNIX timestamp (in seconds) for when the fine-tuning job was last modified.
        /// </param>
        /// <param name="trainingFiles">
        /// A list containing the IDs of uploaded files that contain training data.
        /// </param>
        /// <param name="validationFiles">
        /// A list containing the IDs of uploaded files that contain validation data.<br/>
        /// Default Value: []
        /// </param>
        /// <param name="object">
        /// The object type of the fine-tuning job.<br/>
        /// Default Value: job
        /// </param>
        /// <param name="fineTunedModel">
        /// The name of the fine-tuned model that is being created. The value will be `null` if the fine-tuning job is still running.
        /// </param>
        /// <param name="suffix">
        /// Optional text/code that adds more context for the model. When given a `prompt` and a `suffix` the model will fill what is between them. When `suffix` is not provided, the model will simply execute completion starting with `prompt`.
        /// </param>
        /// <param name="integrations">
        /// A list of integrations enabled for your fine-tuning job.
        /// </param>
        /// <param name="trainedTokens">
        /// Total number of tokens trained.
        /// </param>
        /// <param name="metadata"></param>
        /// <param name="jobType">
        /// The type of job (`FT` for fine-tuning).<br/>
        /// Default Value: completion
        /// </param>
        /// <param name="hyperparameters"></param>
        /// <param name="repositories">
        /// Default Value: []
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CompletionJobOut(
            global::System.Guid id,
            bool autoStart,
            string model,
            global::Mistral.CompletionJobOutStatus status,
            global::System.DateTimeOffset createdAt,
            global::System.DateTimeOffset modifiedAt,
            global::System.Collections.Generic.IList<global::System.Guid> trainingFiles,
            global::Mistral.CompletionTrainingParameters hyperparameters,
            global::System.Collections.Generic.IList<global::System.Guid>? validationFiles,
            string? @object,
            string? fineTunedModel,
            string? suffix,
            global::System.Collections.Generic.IList<global::Mistral.IntegrationsVariant1Item2>? integrations,
            int? trainedTokens,
            global::Mistral.JobMetadataOut? metadata,
            string? jobType,
            global::System.Collections.Generic.IList<global::Mistral.RepositoriesItem>? repositories)
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
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CompletionJobOut" /> class.
        /// </summary>
        public CompletionJobOut()
        {
        }
    }
}