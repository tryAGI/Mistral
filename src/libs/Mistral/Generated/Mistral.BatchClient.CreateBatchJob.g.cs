
#nullable enable

namespace Mistral
{
    public partial class BatchClient
    {


        private static readonly global::Mistral.EndPointSecurityRequirement s_CreateBatchJobSecurityRequirement0 =
            new global::Mistral.EndPointSecurityRequirement
            {
                Authorizations = new global::Mistral.EndPointAuthorizationRequirement[]
                {                    new global::Mistral.EndPointAuthorizationRequirement
                    {
                        Type = "Http",
                        Location = "Header",
                        Name = "Bearer",
                        FriendlyName = "Bearer",
                    },
                },
            };
        private static readonly global::Mistral.EndPointSecurityRequirement[] s_CreateBatchJobSecurityRequirements =
            new global::Mistral.EndPointSecurityRequirement[]
            {                s_CreateBatchJobSecurityRequirement0,
            };
        partial void PrepareCreateBatchJobArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::Mistral.BatchJobIn request);
        partial void PrepareCreateBatchJobRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::Mistral.BatchJobIn request);
        partial void ProcessCreateBatchJobResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessCreateBatchJobResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Create Batch Job<br/>
        /// Create a new batch job, it will be queued for processing.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mistral.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::Mistral.BatchJobOut> CreateBatchJobAsync(

            global::Mistral.BatchJobIn request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareCreateBatchJobArguments(
                httpClient: HttpClient,
                request: request);


            var __authorizations = global::Mistral.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_CreateBatchJobSecurityRequirements,
                operationName: "CreateBatchJobAsync");

            var __pathBuilder = new global::Mistral.PathBuilder(
                path: "/v1/batch/jobs",
                baseUri: HttpClient.BaseAddress);
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
            __httpRequest.Version = global::System.Net.HttpVersion.Version11;
            __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

            foreach (var __authorization in __authorizations)
            {
                if (__authorization.Type == "Http" ||
                    __authorization.Type == "OAuth2")
                {
                    __httpRequest.Headers.Authorization = new global::System.Net.Http.Headers.AuthenticationHeaderValue(
                        scheme: __authorization.Name,
                        parameter: __authorization.Value);
                }
                else if (__authorization.Type == "ApiKey" &&
                         __authorization.Location == "Header")
                {
                    __httpRequest.Headers.Add(__authorization.Name, __authorization.Value);
                }
            }
            var __httpRequestContentBody = request.ToJson(JsonSerializerContext);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            __httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareCreateBatchJobRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessCreateBatchJobResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);

            if (ReadResponseAsString)
            {
                var __content = await __response.Content.ReadAsStringAsync(
#if NET5_0_OR_GREATER
                    cancellationToken
#endif
                ).ConfigureAwait(false);

                ProcessResponseContent(
                    client: HttpClient,
                    response: __response,
                    content: ref __content);
                ProcessCreateBatchJobResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::Mistral.BatchJobOut.FromJson(__content, JsonSerializerContext) ??
                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
                }
                catch (global::System.Exception __ex)
                {
                    throw new global::Mistral.ApiException(
                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                        innerException: __ex,
                        statusCode: __response.StatusCode)
                    {
                        ResponseBody = __content,
                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                            __response.Headers,
                            h => h.Key,
                            h => h.Value),
                    };
                }
            }
            else
            {
                try
                {
                    __response.EnsureSuccessStatusCode();
                    using var __content = await __response.Content.ReadAsStreamAsync(
#if NET5_0_OR_GREATER
                        cancellationToken
#endif
                    ).ConfigureAwait(false);

                    return
                        await global::Mistral.BatchJobOut.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                }
                catch (global::System.Exception __ex)
                {
                    string? __content = null;
                    try
                    {
                        __content = await __response.Content.ReadAsStringAsync(
#if NET5_0_OR_GREATER
                            cancellationToken
#endif
                        ).ConfigureAwait(false);
                    }
                    catch (global::System.Exception)
                    {
                    }

                    throw new global::Mistral.ApiException(
                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                        innerException: __ex,
                        statusCode: __response.StatusCode)
                    {
                        ResponseBody = __content,
                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                            __response.Headers,
                            h => h.Key,
                            h => h.Value),
                    };
                }
            }
        }
        /// <summary>
        /// Create Batch Job<br/>
        /// Create a new batch job, it will be queued for processing.
        /// </summary>
        /// <param name="inputFiles">
        /// The list of input files to be used for batch inference, these files should be `jsonl` files, containing the input data corresponding to the bory request for the batch inference in a "body" field. An example of such file is the following: ```json {"custom_id": "0", "body": {"max_tokens": 100, "messages": [{"role": "user", "content": "What is the best French cheese?"}]}} {"custom_id": "1", "body": {"max_tokens": 100, "messages": [{"role": "user", "content": "What is the best French wine?"}]}} ```
        /// </param>
        /// <param name="requests"></param>
        /// <param name="endpoint">
        /// The endpoint to be used for batch inference.
        /// </param>
        /// <param name="model">
        /// The model to be used for batch inference.
        /// </param>
        /// <param name="agentId">
        /// In case you want to use a specific agent from the **deprecated** agents api for batch inference, you can specify the agent ID here.
        /// </param>
        /// <param name="metadata">
        /// The metadata of your choice to be associated with the batch inference job.
        /// </param>
        /// <param name="timeoutHours">
        /// The timeout in hours for the batch inference job.<br/>
        /// Default Value: 24
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::Mistral.BatchJobOut> CreateBatchJobAsync(
            global::Mistral.ApiEndpoint endpoint,
            global::System.Collections.Generic.IList<global::System.Guid>? inputFiles = default,
            global::System.Collections.Generic.IList<global::Mistral.BatchRequest>? requests = default,
            string? model = default,
            string? agentId = default,
            global::System.Collections.Generic.Dictionary<string, string>? metadata = default,
            int? timeoutHours = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::Mistral.BatchJobIn
            {
                InputFiles = inputFiles,
                Requests = requests,
                Endpoint = endpoint,
                Model = model,
                AgentId = agentId,
                Metadata = metadata,
                TimeoutHours = timeoutHours,
            };

            return await CreateBatchJobAsync(
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}