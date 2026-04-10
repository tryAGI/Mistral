
#nullable enable

namespace Mistral
{
    /// <summary>
    /// Our Chat Completion and Embeddings APIs specification. Create your account on [La Plateforme](https://console.mistral.ai) to get access and read the [docs](https://docs.mistral.ai) to learn how to use it.<br/>
    /// If no httpClient is provided, a new one will be created.<br/>
    /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
    /// </summary>
    public sealed partial class MistralClient : global::Mistral.IMistralClient, global::System.IDisposable
    {
        /// <summary>
        /// Production server
        /// </summary>
        public const string DefaultBaseUrl = "https://api.mistral.ai/";

        private bool _disposeHttpClient = true;

        /// <inheritdoc/>
        public global::System.Net.Http.HttpClient HttpClient { get; }

        /// <inheritdoc/>
        public System.Uri? BaseUri => HttpClient.BaseAddress;

        /// <inheritdoc/>
        public global::System.Collections.Generic.List<global::Mistral.EndPointAuthorization> Authorizations { get; }

        /// <inheritdoc/>
        public bool ReadResponseAsString { get; set; }
#if DEBUG
            = true;
#endif

        /// <inheritdoc/>
        public global::Mistral.AutoSDKClientOptions Options { get; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Text.Json.Serialization.JsonSerializerContext JsonSerializerContext { get; set; } = global::Mistral.SourceGenerationContext.Default;


        /// <summary>
        /// Speech API. API for text-to-speech generation.
        /// </summary>
        public AudioSpeechClient AudioSpeech => new AudioSpeechClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContext = JsonSerializerContext,
        };

        /// <summary>
        /// Transcriptions API. API for audio transcription.
        /// </summary>
        public AudioTranscriptionsClient AudioTranscriptions => new AudioTranscriptionsClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContext = JsonSerializerContext,
        };

        /// <summary>
        /// Voices API. API for managing custom voice profiles.
        /// </summary>
        public AudioVoicesClient AudioVoices => new AudioVoicesClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContext = JsonSerializerContext,
        };

        /// <summary>
        /// Batch. Batch API.
        /// </summary>
        public BatchClient Batch => new BatchClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContext = JsonSerializerContext,
        };

        /// <summary>
        /// (beta) Agents API.
        /// </summary>
        public BetaAgentsClient BetaAgents => new BetaAgentsClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContext = JsonSerializerContext,
        };

        /// <summary>
        /// (beta) Connectors API. (beta) Connectors API to create, manage, and call tools on MCP connectors.
        /// </summary>
        public BetaConnectorsClient BetaConnectors => new BetaConnectorsClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContext = JsonSerializerContext,
        };

        /// <summary>
        /// (beta) Conversations API.
        /// </summary>
        public BetaConversationsClient BetaConversations => new BetaConversationsClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContext = JsonSerializerContext,
        };

        /// <summary>
        /// (beta) Libraries  API - Main. (beta) Libraries API to create and manage libraries - index your documents to enhance agent capabilities.
        /// </summary>
        public BetaLibrariesClient BetaLibraries => new BetaLibrariesClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContext = JsonSerializerContext,
        };

        /// <summary>
        /// (beta) Libraries  API - Access. (beta) Libraries API - manage access to a library.
        /// </summary>
        public BetaLibrariesAccessesClient BetaLibrariesAccesses => new BetaLibrariesAccessesClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContext = JsonSerializerContext,
        };

        /// <summary>
        /// (beta) Libraries  API - Documents. (beta) Libraries API - manage documents in a library.
        /// </summary>
        public BetaLibrariesDocumentsClient BetaLibrariesDocuments => new BetaLibrariesDocumentsClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContext = JsonSerializerContext,
        };

        /// <summary>
        /// (beta) Observability - Campaigns. (beta) Create and manage evaluation campaigns.
        /// </summary>
        public BetaObservabilityCampaignsClient BetaObservabilityCampaigns => new BetaObservabilityCampaignsClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContext = JsonSerializerContext,
        };

        /// <summary>
        /// (beta) Observability - Chat completion events. (beta) Search, retrieve, and analyze chat completion events.
        /// </summary>
        public BetaObservabilityChatCompletionEventsClient BetaObservabilityChatCompletionEvents => new BetaObservabilityChatCompletionEventsClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContext = JsonSerializerContext,
        };

        /// <summary>
        /// (beta) Observability - Chat completion fields. (beta) List and inspect filterable fields for chat completion events.
        /// </summary>
        public BetaObservabilityChatCompletionEventsFieldsClient BetaObservabilityChatCompletionEventsFields => new BetaObservabilityChatCompletionEventsFieldsClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContext = JsonSerializerContext,
        };

        /// <summary>
        /// (beta) Observability - Datasets. (beta) Create, update, import, and export datasets.
        /// </summary>
        public BetaObservabilityDatasetsClient BetaObservabilityDatasets => new BetaObservabilityDatasetsClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContext = JsonSerializerContext,
        };

        /// <summary>
        /// (beta) Observability - Dataset records. (beta) Manage individual records within datasets.
        /// </summary>
        public BetaObservabilityDatasetsRecordsClient BetaObservabilityDatasetsRecords => new BetaObservabilityDatasetsRecordsClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContext = JsonSerializerContext,
        };

        /// <summary>
        /// (beta) Observability - Judges. (beta) Create, update, and manage judges for evaluating chat completions.
        /// </summary>
        public BetaObservabilityJudgesClient BetaObservabilityJudges => new BetaObservabilityJudgesClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContext = JsonSerializerContext,
        };

        /// <summary>
        /// Chat. Chat Completion API.
        /// </summary>
        public ChatClient Chat => new ChatClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContext = JsonSerializerContext,
        };

        /// <summary>
        /// Classifiers. Classifiers API.
        /// </summary>
        public ClassifiersClient Classifiers => new ClassifiersClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContext = JsonSerializerContext,
        };

        /// <summary>
        /// (deprecated) Fine Tuning. (deprecated) Fine-tuning API.
        /// </summary>
        public DeprecatedFineTuningClient DeprecatedFineTuning => new DeprecatedFineTuningClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContext = JsonSerializerContext,
        };

        /// <summary>
        /// Embeddings. Embeddings API.
        /// </summary>
        public EmbeddingsClient Embeddings => new EmbeddingsClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContext = JsonSerializerContext,
        };

        /// <summary>
        /// Files. Files API.
        /// </summary>
        public FilesClient Files => new FilesClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContext = JsonSerializerContext,
        };

        /// <summary>
        /// FIM. Fill-in-the-middle API.
        /// </summary>
        public FimClient Fim => new FimClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContext = JsonSerializerContext,
        };

        /// <summary>
        /// Models. Model Management API.
        /// </summary>
        public ModelsClient Models => new ModelsClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContext = JsonSerializerContext,
        };

        /// <summary>
        /// OCR API.
        /// </summary>
        public OcrClient Ocr => new OcrClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContext = JsonSerializerContext,
        };

        /// <summary>
        /// Workflows. Workflow management API.
        /// </summary>
        public WorkflowsClient Workflows => new WorkflowsClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContext = JsonSerializerContext,
        };

        /// <summary>
        /// Deployments. List and inspect worker deployments.
        /// </summary>
        public WorkflowsDeploymentsClient WorkflowsDeployments => new WorkflowsDeploymentsClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContext = JsonSerializerContext,
        };

        /// <summary>
        /// Events. Stream and list workflow execution events.
        /// </summary>
        public WorkflowsEventsClient WorkflowsEvents => new WorkflowsEventsClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContext = JsonSerializerContext,
        };

        /// <summary>
        /// Executions. Trigger, monitor, and control workflow executions.
        /// </summary>
        public WorkflowsExecutionsClient WorkflowsExecutions => new WorkflowsExecutionsClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContext = JsonSerializerContext,
        };

        /// <summary>
        /// Metrics. Get performance metrics for workflows.
        /// </summary>
        public WorkflowsMetricsClient WorkflowsMetrics => new WorkflowsMetricsClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContext = JsonSerializerContext,
        };

        /// <summary>
        /// Runs. List and inspect individual workflow runs.
        /// </summary>
        public WorkflowsRunsClient WorkflowsRuns => new WorkflowsRunsClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContext = JsonSerializerContext,
        };

        /// <summary>
        /// Schedules. Create and manage workflow schedules.
        /// </summary>
        public WorkflowsSchedulesClient WorkflowsSchedules => new WorkflowsSchedulesClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContext = JsonSerializerContext,
        };

        /// <summary>
        /// Workers. Worker connection info.
        /// </summary>
        public WorkflowsWorkersClient WorkflowsWorkers => new WorkflowsWorkersClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContext = JsonSerializerContext,
        };

        /// <summary>
        /// Creates a new instance of the MistralClient.
        /// If no httpClient is provided, a new one will be created.
        /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
        /// </summary>
        /// <param name="httpClient">The HttpClient instance. If not provided, a new one will be created.</param>
        /// <param name="baseUri">The base URL for the API. If not provided, the default baseUri from OpenAPI spec will be used.</param>
        /// <param name="authorizations">The authorizations to use for the requests.</param>
        /// <param name="disposeHttpClient">Dispose the HttpClient when the instance is disposed. True by default.</param>
        public MistralClient(
            global::System.Net.Http.HttpClient? httpClient = null,
            global::System.Uri? baseUri = null,
            global::System.Collections.Generic.List<global::Mistral.EndPointAuthorization>? authorizations = null,
            bool disposeHttpClient = true) : this(
                httpClient,
                baseUri,
                authorizations,
                options: null,
                disposeHttpClient: disposeHttpClient)
        {
        }

        /// <summary>
        /// Creates a new instance of the MistralClient.
        /// If no httpClient is provided, a new one will be created.
        /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
        /// </summary>
        /// <param name="httpClient">The HttpClient instance. If not provided, a new one will be created.</param>
        /// <param name="baseUri">The base URL for the API. If not provided, the default baseUri from OpenAPI spec will be used.</param>
        /// <param name="authorizations">The authorizations to use for the requests.</param>
        /// <param name="options">Client-wide request defaults such as headers, query parameters, retries, and timeout.</param>
        /// <param name="disposeHttpClient">Dispose the HttpClient when the instance is disposed. True by default.</param>
        public MistralClient(
            global::System.Net.Http.HttpClient? httpClient = null,
            global::System.Uri? baseUri = null,
            global::System.Collections.Generic.List<global::Mistral.EndPointAuthorization>? authorizations = null,
            global::Mistral.AutoSDKClientOptions? options = null,
            bool disposeHttpClient = true)
        {

            HttpClient = httpClient ?? new global::System.Net.Http.HttpClient();
            HttpClient.BaseAddress ??= baseUri ?? new global::System.Uri(DefaultBaseUrl);
            Authorizations = authorizations ?? new global::System.Collections.Generic.List<global::Mistral.EndPointAuthorization>();
            Options = options ?? new global::Mistral.AutoSDKClientOptions();
            _disposeHttpClient = disposeHttpClient;

            Initialized(HttpClient);
        }

        /// <inheritdoc/>
        public void Dispose()
        {
            if (_disposeHttpClient)
            {
                HttpClient.Dispose();
            }
        }

        partial void Initialized(
            global::System.Net.Http.HttpClient client);
        partial void PrepareArguments(
            global::System.Net.Http.HttpClient client);
        partial void PrepareRequest(
            global::System.Net.Http.HttpClient client,
            global::System.Net.Http.HttpRequestMessage request);
        partial void ProcessResponse(
            global::System.Net.Http.HttpClient client,
            global::System.Net.Http.HttpResponseMessage response);
        partial void ProcessResponseContent(
            global::System.Net.Http.HttpClient client,
            global::System.Net.Http.HttpResponseMessage response,
            ref string content);
    }
}