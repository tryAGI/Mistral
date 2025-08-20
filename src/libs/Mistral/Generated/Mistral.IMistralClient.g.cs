
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
        /// </summary>
        public bool ReadResponseAsString { get; set; }

        /// <summary>
        /// 
        /// </summary>
        global::System.Text.Json.Serialization.JsonSerializerContext JsonSerializerContext { get; set; }


        /// <summary>
        /// Chat Completion API.
        /// </summary>
        public ChatClient Chat { get; }

        /// <summary>
        /// Fill-in-the-middle API.
        /// </summary>
        public FimClient Fim { get; }

        /// <summary>
        /// Agents API.
        /// </summary>
        public AgentsClient Agents { get; }

        /// <summary>
        /// Embeddings API.
        /// </summary>
        public EmbeddingsClient Embeddings { get; }

        /// <summary>
        /// Classifiers API.
        /// </summary>
        public ClassifiersClient Classifiers { get; }

        /// <summary>
        /// Files API
        /// </summary>
        public FilesClient Files { get; }

        /// <summary>
        /// Fine-tuning API
        /// </summary>
        public FineTuningClient FineTuning { get; }

        /// <summary>
        /// Model Management API
        /// </summary>
        public ModelsClient Models { get; }

        /// <summary>
        /// Batch API
        /// </summary>
        public BatchClient Batch { get; }

        /// <summary>
        /// OCR API
        /// </summary>
        public OcrClient Ocr { get; }

        /// <summary>
        /// API for audio transcription.
        /// </summary>
        public AudioTranscriptionsClient AudioTranscriptions { get; }

        /// <summary>
        /// (beta) Agents API
        /// </summary>
        public BetaAgentsClient BetaAgents { get; }

        /// <summary>
        /// (beta) Conversations API
        /// </summary>
        public BetaConversationsClient BetaConversations { get; }

        /// <summary>
        /// (beta) Libraries API to create and manage libraries - index your documents to enhance agent capabilities.
        /// </summary>
        public BetaLibrariesClient BetaLibraries { get; }

        /// <summary>
        /// (beta) Libraries API - manage documents in a library.
        /// </summary>
        public BetaLibrariesDocumentsClient BetaLibrariesDocuments { get; }

        /// <summary>
        /// (beta) Libraries API - manage access to a library.
        /// </summary>
        public BetaLibrariesAccessesClient BetaLibrariesAccesses { get; }

    }
}