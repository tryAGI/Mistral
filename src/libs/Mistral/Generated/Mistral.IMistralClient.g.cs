
#nullable enable

namespace Mistral
{
    /// <summary>
    /// Our Chat Completion and Embeddings APIs specification. Create your account on [La Plateforme](https://console.mistral.ai) to get access and read the [docs](https://docs.mistral.ai) to learn how to use it.<br/>
    /// If no httpClient is provided, a new one will be created.<br/>
    /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
    /// </summary>
    public partial interface IMistralClient : global::System.IDisposable
    {
        /// <summary>
        /// The HttpClient instance.
        /// </summary>
        public global::System.Net.Http.HttpClient HttpClient { get; }

        /// <summary>
        /// The base URL for the API.
        /// </summary>
        public System.Uri? BaseUri { get; }

        /// <summary>
        /// The authorizations to use for the requests.
        /// </summary>
        public global::System.Collections.Generic.List<global::Mistral.EndPointAuthorization> Authorizations { get; }

        /// <summary>
        /// Gets or sets a value indicating whether the response content should be read as a string.
        /// True by default in debug builds, false otherwise.
        /// When false, successful responses are deserialized directly from the response stream for better performance.
        /// Error responses are always read as strings regardless of this setting,
        /// ensuring <see cref="ApiException.ResponseBody"/> is populated.
        /// </summary>
        public bool ReadResponseAsString { get; set; }

        /// <summary>
        /// Client-wide request defaults such as headers, query parameters, retries, and timeout.
        /// </summary>
        public global::Mistral.AutoSDKClientOptions Options { get; }

        /// <summary>
        /// 
        /// </summary>
        global::System.Text.Json.Serialization.JsonSerializerContext JsonSerializerContext { get; set; }


        /// <summary>
        /// Speech API. API for text-to-speech generation.
        /// </summary>
        public AudioSpeechClient AudioSpeech { get; }

        /// <summary>
        /// Transcriptions API. API for audio transcription.
        /// </summary>
        public AudioTranscriptionsClient AudioTranscriptions { get; }

        /// <summary>
        /// Voices API. API for managing custom voice profiles.
        /// </summary>
        public AudioVoicesClient AudioVoices { get; }

        /// <summary>
        /// Batch. Batch API.
        /// </summary>
        public BatchClient Batch { get; }

        /// <summary>
        /// (beta) Agents API.
        /// </summary>
        public BetaAgentsClient BetaAgents { get; }

        /// <summary>
        /// (beta) Conversations API.
        /// </summary>
        public BetaConversationsClient BetaConversations { get; }

        /// <summary>
        /// (beta) Libraries  API - Main. (beta) Libraries API to create and manage libraries - index your documents to enhance agent capabilities.
        /// </summary>
        public BetaLibrariesClient BetaLibraries { get; }

        /// <summary>
        /// (beta) Libraries  API - Access. (beta) Libraries API - manage access to a library.
        /// </summary>
        public BetaLibrariesAccessesClient BetaLibrariesAccesses { get; }

        /// <summary>
        /// (beta) Libraries  API - Documents. (beta) Libraries API - manage documents in a library.
        /// </summary>
        public BetaLibrariesDocumentsClient BetaLibrariesDocuments { get; }

        /// <summary>
        /// (beta) Observability - Campaigns. (beta) Create and manage evaluation campaigns.
        /// </summary>
        public BetaObservabilityCampaignsClient BetaObservabilityCampaigns { get; }

        /// <summary>
        /// (beta) Observability - Chat completion events. (beta) Search, retrieve, and analyze chat completion events.
        /// </summary>
        public BetaObservabilityChatCompletionEventsClient BetaObservabilityChatCompletionEvents { get; }

        /// <summary>
        /// (beta) Observability - Chat completion fields. (beta) List and inspect filterable fields for chat completion events.
        /// </summary>
        public BetaObservabilityChatCompletionEventsFieldsClient BetaObservabilityChatCompletionEventsFields { get; }

        /// <summary>
        /// (beta) Observability - Datasets. (beta) Create, update, import, and export datasets.
        /// </summary>
        public BetaObservabilityDatasetsClient BetaObservabilityDatasets { get; }

        /// <summary>
        /// (beta) Observability - Dataset records. (beta) Manage individual records within datasets.
        /// </summary>
        public BetaObservabilityDatasetsRecordsClient BetaObservabilityDatasetsRecords { get; }

        /// <summary>
        /// (beta) Observability - Judges. (beta) Create, update, and manage judges for evaluating chat completions.
        /// </summary>
        public BetaObservabilityJudgesClient BetaObservabilityJudges { get; }

        /// <summary>
        /// Workflows. Workflow management API.
        /// </summary>
        public BetaWorkflowsClient BetaWorkflows { get; }

        /// <summary>
        /// Deployments. List and inspect worker deployments.
        /// </summary>
        public BetaWorkflowsDeploymentsClient BetaWorkflowsDeployments { get; }

        /// <summary>
        /// Events. Stream and list workflow execution events.
        /// </summary>
        public BetaWorkflowsEventsClient BetaWorkflowsEvents { get; }

        /// <summary>
        /// Executions. Trigger, monitor, and control workflow executions.
        /// </summary>
        public BetaWorkflowsExecutionsClient BetaWorkflowsExecutions { get; }

        /// <summary>
        /// Metrics. Get performance metrics for workflows.
        /// </summary>
        public BetaWorkflowsMetricsClient BetaWorkflowsMetrics { get; }

        /// <summary>
        /// Runs. List and inspect individual workflow runs.
        /// </summary>
        public BetaWorkflowsRunsClient BetaWorkflowsRuns { get; }

        /// <summary>
        /// Schedules. Create and manage workflow schedules.
        /// </summary>
        public BetaWorkflowsSchedulesClient BetaWorkflowsSchedules { get; }

        /// <summary>
        /// Workers. Worker connection info.
        /// </summary>
        public BetaWorkflowsWorkersClient BetaWorkflowsWorkers { get; }

        /// <summary>
        /// Chat. Chat Completion API.
        /// </summary>
        public ChatClient Chat { get; }

        /// <summary>
        /// Classifiers. Classifiers API.
        /// </summary>
        public ClassifiersClient Classifiers { get; }

        /// <summary>
        /// (deprecated) Fine Tuning. (deprecated) Fine-tuning API.
        /// </summary>
        public DeprecatedFineTuningClient DeprecatedFineTuning { get; }

        /// <summary>
        /// Embeddings. Embeddings API.
        /// </summary>
        public EmbeddingsClient Embeddings { get; }

        /// <summary>
        /// Files. Files API.
        /// </summary>
        public FilesClient Files { get; }

        /// <summary>
        /// FIM. Fill-in-the-middle API.
        /// </summary>
        public FimClient Fim { get; }

        /// <summary>
        /// Models. Model Management API.
        /// </summary>
        public ModelsClient Models { get; }

        /// <summary>
        /// OCR API.
        /// </summary>
        public OcrClient Ocr { get; }

    }
}