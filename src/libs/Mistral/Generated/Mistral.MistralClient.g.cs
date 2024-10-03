
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
        public const string BaseUrl = "https://api.mistral.ai";

        private readonly global::System.Net.Http.HttpClient _httpClient;
        private global::System.Collections.Generic.List<global::Mistral.EndPointAuthorization> _authorizations;

        /// <summary>
        /// 
        /// </summary>
        public global::System.Text.Json.Serialization.JsonSerializerContext JsonSerializerContext { get; set; } = global::Mistral.SourceGenerationContext.Default;


        /// <summary>
        /// Chat Completion API.
        /// </summary>
        public ChatClient Chat => new ChatClient(_httpClient, authorizations: _authorizations)
        {
            JsonSerializerContext = JsonSerializerContext,
        };

        /// <summary>
        /// Fill-in-the-middle API.
        /// </summary>
        public FimClient Fim => new FimClient(_httpClient, authorizations: _authorizations)
        {
            JsonSerializerContext = JsonSerializerContext,
        };

        /// <summary>
        /// Agents API.
        /// </summary>
        public AgentsClient Agents => new AgentsClient(_httpClient, authorizations: _authorizations)
        {
            JsonSerializerContext = JsonSerializerContext,
        };

        /// <summary>
        /// Embeddings API.
        /// </summary>
        public EmbeddingsClient Embeddings => new EmbeddingsClient(_httpClient, authorizations: _authorizations)
        {
            JsonSerializerContext = JsonSerializerContext,
        };

        /// <summary>
        /// Files API
        /// </summary>
        public FilesClient Files => new FilesClient(_httpClient, authorizations: _authorizations)
        {
            JsonSerializerContext = JsonSerializerContext,
        };

        /// <summary>
        /// Fine-tuning API
        /// </summary>
        public FineTuningClient FineTuning => new FineTuningClient(_httpClient, authorizations: _authorizations)
        {
            JsonSerializerContext = JsonSerializerContext,
        };

        /// <summary>
        /// Model Management API
        /// </summary>
        public ModelsClient Models => new ModelsClient(_httpClient, authorizations: _authorizations)
        {
            JsonSerializerContext = JsonSerializerContext,
        };

        /// <summary>
        /// Creates a new instance of the MistralClient.
        /// If no httpClient is provided, a new one will be created.
        /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
        /// </summary>
        /// <param name="httpClient"></param>
        /// <param name="baseUri"></param>
        /// <param name="authorizations"></param>
        public MistralClient(
            global::System.Net.Http.HttpClient? httpClient = null,
            global::System.Uri? baseUri = null,
            global::System.Collections.Generic.List<global::Mistral.EndPointAuthorization>? authorizations = null)
        {
            _httpClient = httpClient ?? new global::System.Net.Http.HttpClient();
            _httpClient.BaseAddress ??= baseUri ?? new global::System.Uri(BaseUrl);
            _authorizations = authorizations ?? new global::System.Collections.Generic.List<global::Mistral.EndPointAuthorization>();

            Initialized(_httpClient);
        }

        /// <inheritdoc/>
        public void Dispose()
        {
            _httpClient.Dispose();
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