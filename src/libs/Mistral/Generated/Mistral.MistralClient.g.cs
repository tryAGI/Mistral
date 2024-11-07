
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
        public const string DefaultBaseUrl = "https://api.mistral.ai";

        private bool _disposeHttpClient = true;

        /// <inheritdoc/>
        public global::System.Net.Http.HttpClient HttpClient { get; }

        /// <inheritdoc/>
        public System.Uri? BaseUri => HttpClient.BaseAddress;

        /// <inheritdoc/>
        public global::System.Collections.Generic.List<global::Mistral.EndPointAuthorization> Authorizations { get; }

        /// <summary>
        /// 
        /// </summary>
        public global::System.Text.Json.Serialization.JsonSerializerContext JsonSerializerContext { get; set; } = global::Mistral.SourceGenerationContext.Default;


        /// <summary>
        /// Chat Completion API.
        /// </summary>
        public ChatClient Chat => new ChatClient(HttpClient, authorizations: Authorizations)
        {
            JsonSerializerContext = JsonSerializerContext,
        };

        /// <summary>
        /// Fill-in-the-middle API.
        /// </summary>
        public FimClient Fim => new FimClient(HttpClient, authorizations: Authorizations)
        {
            JsonSerializerContext = JsonSerializerContext,
        };

        /// <summary>
        /// Agents API.
        /// </summary>
        public AgentsClient Agents => new AgentsClient(HttpClient, authorizations: Authorizations)
        {
            JsonSerializerContext = JsonSerializerContext,
        };

        /// <summary>
        /// Embeddings API.
        /// </summary>
        public EmbeddingsClient Embeddings => new EmbeddingsClient(HttpClient, authorizations: Authorizations)
        {
            JsonSerializerContext = JsonSerializerContext,
        };

        /// <summary>
        /// Classifiers API.
        /// </summary>
        public ClassifiersClient Classifiers => new ClassifiersClient(HttpClient, authorizations: Authorizations)
        {
            JsonSerializerContext = JsonSerializerContext,
        };

        /// <summary>
        /// Files API
        /// </summary>
        public FilesClient Files => new FilesClient(HttpClient, authorizations: Authorizations)
        {
            JsonSerializerContext = JsonSerializerContext,
        };

        /// <summary>
        /// Fine-tuning API
        /// </summary>
        public FineTuningClient FineTuning => new FineTuningClient(HttpClient, authorizations: Authorizations)
        {
            JsonSerializerContext = JsonSerializerContext,
        };

        /// <summary>
        /// Model Management API
        /// </summary>
        public ModelsClient Models => new ModelsClient(HttpClient, authorizations: Authorizations)
        {
            JsonSerializerContext = JsonSerializerContext,
        };

        /// <summary>
        /// Batch API
        /// </summary>
        public BatchClient Batch => new BatchClient(HttpClient, authorizations: Authorizations)
        {
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
            bool disposeHttpClient = true)
        {
            HttpClient = httpClient ?? new global::System.Net.Http.HttpClient();
            HttpClient.BaseAddress ??= baseUri ?? new global::System.Uri(DefaultBaseUrl);
            Authorizations = authorizations ?? new global::System.Collections.Generic.List<global::Mistral.EndPointAuthorization>();
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