
#nullable enable

namespace Mistral
{
    public partial class BetaAgentsClient
    {


        private static readonly global::Mistral.EndPointSecurityRequirement s_ListAgentEntities_CursorPaginatedSecurityRequirement0 =
            new global::Mistral.EndPointSecurityRequirement
            {
                Authorizations = new global::Mistral.EndPointAuthorizationRequirement[]
                {                    new global::Mistral.EndPointAuthorizationRequirement
                    {
                        Type = "Http",
                        SchemeId = "ApiKey",
                        Location = "Header",
                        Name = "Bearer",
                        FriendlyName = "Bearer",
                    },
                },
            };
        private static readonly global::Mistral.EndPointSecurityRequirement[] s_ListAgentEntities_CursorPaginatedSecurityRequirements =
            new global::Mistral.EndPointSecurityRequirement[]
            {                s_ListAgentEntities_CursorPaginatedSecurityRequirement0,
            };
        partial void PrepareListAgentEntities_CursorPaginatedArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref int? pageSize,
            bool? deploymentChat,
            global::System.Collections.Generic.IList<global::Mistral.RequestSource>? sources,
            ref string? name,
            ref string? search,
            ref string? id,
            ref string? pageToken,
            object? metadata);
        partial void PrepareListAgentEntities_CursorPaginatedRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            int? pageSize,
            bool? deploymentChat,
            global::System.Collections.Generic.IList<global::Mistral.RequestSource>? sources,
            string? name,
            string? search,
            string? id,
            string? pageToken,
            object? metadata);
        partial void ProcessListAgentEntities_CursorPaginatedResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessListAgentEntities_CursorPaginatedResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// List agent entities, cursor-paginated.<br/>
        /// Retrieve a page of agent entities. Unlike the deprecated `GET /v1/agents`, this endpoint paginates by opaque cursor and honors per-agent sharing, returning only agents the caller is authorized to see.
        /// </summary>
        /// <param name="pageSize">
        /// Number of agents per page<br/>
        /// Default Value: 20
        /// </param>
        /// <param name="deploymentChat"></param>
        /// <param name="sources"></param>
        /// <param name="name">
        /// Filter by agent name
        /// </param>
        /// <param name="search">
        /// Search agents by name or ID
        /// </param>
        /// <param name="id"></param>
        /// <param name="pageToken">
        /// Opaque cursor from a previous response's next_page_token. When set, results page forward from the cursor.
        /// </param>
        /// <param name="metadata"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mistral.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::Mistral.AgentListPage> ListAgentEntities_CursorPaginatedAsync(
            int? pageSize = default,
            bool? deploymentChat = default,
            global::System.Collections.Generic.IList<global::Mistral.RequestSource>? sources = default,
            string? name = default,
            string? search = default,
            string? id = default,
            string? pageToken = default,
            object? metadata = default,
            global::Mistral.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __response = await ListAgentEntities_CursorPaginatedAsResponseAsync(
                pageSize: pageSize,
                deploymentChat: deploymentChat,
                sources: sources,
                name: name,
                search: search,
                id: id,
                pageToken: pageToken,
                metadata: metadata,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken
            ).ConfigureAwait(false);

            return __response.Body;
        }
        /// <summary>
        /// List agent entities, cursor-paginated.<br/>
        /// Retrieve a page of agent entities. Unlike the deprecated `GET /v1/agents`, this endpoint paginates by opaque cursor and honors per-agent sharing, returning only agents the caller is authorized to see.
        /// </summary>
        /// <param name="pageSize">
        /// Number of agents per page<br/>
        /// Default Value: 20
        /// </param>
        /// <param name="deploymentChat"></param>
        /// <param name="sources"></param>
        /// <param name="name">
        /// Filter by agent name
        /// </param>
        /// <param name="search">
        /// Search agents by name or ID
        /// </param>
        /// <param name="id"></param>
        /// <param name="pageToken">
        /// Opaque cursor from a previous response's next_page_token. When set, results page forward from the cursor.
        /// </param>
        /// <param name="metadata"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mistral.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::Mistral.AutoSDKHttpResponse<global::Mistral.AgentListPage>> ListAgentEntities_CursorPaginatedAsResponseAsync(
            int? pageSize = default,
            bool? deploymentChat = default,
            global::System.Collections.Generic.IList<global::Mistral.RequestSource>? sources = default,
            string? name = default,
            string? search = default,
            string? id = default,
            string? pageToken = default,
            object? metadata = default,
            global::Mistral.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareListAgentEntities_CursorPaginatedArguments(
                httpClient: HttpClient,
                pageSize: ref pageSize,
                deploymentChat: deploymentChat,
                sources: sources,
                name: ref name,
                search: ref search,
                id: ref id,
                pageToken: ref pageToken,
                metadata: metadata);


            var __authorizations = global::Mistral.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_ListAgentEntities_CursorPaginatedSecurityRequirements,
                operationName: "ListAgentEntities_CursorPaginatedAsync");

            using var __timeoutCancellationTokenSource = global::Mistral.AutoSDKRequestOptionsSupport.CreateTimeoutCancellationTokenSource(
                clientOptions: Options,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken);
            var __effectiveCancellationToken = __timeoutCancellationTokenSource?.Token ?? cancellationToken;
            var __effectiveReadResponseAsString = global::Mistral.AutoSDKRequestOptionsSupport.GetReadResponseAsString(
                clientOptions: Options,
                requestOptions: requestOptions,
                fallbackValue: ReadResponseAsString);
            var __maxAttempts = global::Mistral.AutoSDKRequestOptionsSupport.GetMaxAttempts(
                clientOptions: Options,
                requestOptions: requestOptions,
                supportsRetry: true);

            global::System.Net.Http.HttpRequestMessage __CreateHttpRequest()
            {

                            var __pathBuilder = new global::Mistral.PathBuilder(
                                path: "/v1/agents/pages",
                                baseUri: HttpClient.BaseAddress);
                            __pathBuilder
                                .AddOptionalParameter("page_size", pageSize?.ToString())
                                .AddOptionalParameter("deployment_chat", deploymentChat?.ToString().ToLowerInvariant())
                                .AddOptionalParameter("sources", sources?.ToString())
                                .AddOptionalParameter("name", name)
                                .AddOptionalParameter("search", search)
                                .AddOptionalParameter("id", id)
                                .AddOptionalParameter("page_token", pageToken)
                                .AddOptionalParameter("metadata", metadata?.ToString())
                                ;
                            var __path = __pathBuilder.ToString();
                __path = global::Mistral.AutoSDKRequestOptionsSupport.AppendQueryParameters(
                    path: __path,
                    clientParameters: Options.QueryParameters,
                    requestParameters: requestOptions?.QueryParameters);
                var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                    method: global::System.Net.Http.HttpMethod.Get,
                    requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
                __httpRequest.Version = global::System.Net.HttpVersion.Version11;
                __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

            foreach (var __authorization in __authorizations)
            {
                if (__authorization.Type == "Http" ||
                    __authorization.Type == "OAuth2" ||
                    __authorization.Type == "OpenIdConnect")
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
                global::Mistral.AutoSDKRequestOptionsSupport.ApplyHeaders(
                    request: __httpRequest,
                    clientHeaders: Options.Headers,
                    requestHeaders: requestOptions?.Headers);

                PrepareRequest(
                    client: HttpClient,
                    request: __httpRequest);
                PrepareListAgentEntities_CursorPaginatedRequest(
                    httpClient: HttpClient,
                    httpRequestMessage: __httpRequest,
                    pageSize: pageSize,
                    deploymentChat: deploymentChat,
                    sources: sources,
                    name: name,
                    search: search,
                    id: id,
                    pageToken: pageToken,
                    metadata: metadata);

                return __httpRequest;
            }

            global::System.Net.Http.HttpRequestMessage? __httpRequest = null;
            global::System.Net.Http.HttpResponseMessage? __response = null;
            var __attemptNumber = 0;
            try
            {
                for (var __attempt = 1; __attempt <= __maxAttempts; __attempt++)
                {
                    __attemptNumber = __attempt;
                    __httpRequest = __CreateHttpRequest();
                    await global::Mistral.AutoSDKRequestOptionsSupport.OnBeforeRequestAsync(
                            clientOptions: Options,
                            context: global::Mistral.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "ListAgentEntities_CursorPaginated",
                                methodName: "ListAgentEntities_CursorPaginatedAsync",
                                pathTemplate: "\"/v1/agents/pages\"",
                                httpMethod: "GET",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: null,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                retryDelay: null,
                                retryReason: global::System.String.Empty,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                    try
                    {
                        __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                    }
                    catch (global::System.Net.Http.HttpRequestException __exception)
                    {
                        var __retryDelay = global::Mistral.AutoSDKRequestOptionsSupport.GetRetryDelay(
                            clientOptions: Options,
                            requestOptions: requestOptions,
                            response: null,
                            attempt: __attempt);
                        var __willRetry = __attempt < __maxAttempts && !__effectiveCancellationToken.IsCancellationRequested;
                        await global::Mistral.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::Mistral.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "ListAgentEntities_CursorPaginated",
                                methodName: "ListAgentEntities_CursorPaginatedAsync",
                                pathTemplate: "\"/v1/agents/pages\"",
                                httpMethod: "GET",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: null,
                                exception: __exception,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: __willRetry,
                                retryDelay: __willRetry ? __retryDelay : (global::System.TimeSpan?)null,
                                retryReason: "exception",
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                        if (!__willRetry)
                        {
                            throw;
                        }

                        __httpRequest.Dispose();
                        __httpRequest = null;
                        await global::Mistral.AutoSDKRequestOptionsSupport.DelayBeforeRetryAsync(
                            retryDelay: __retryDelay,
                            cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                        continue;
                    }

                    if (__response != null &&
                        __attempt < __maxAttempts &&
                        global::Mistral.AutoSDKRequestOptionsSupport.ShouldRetryStatusCode(__response.StatusCode))
                    {
                        var __retryDelay = global::Mistral.AutoSDKRequestOptionsSupport.GetRetryDelay(
                            clientOptions: Options,
                            requestOptions: requestOptions,
                            response: __response,
                            attempt: __attempt);
                        await global::Mistral.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::Mistral.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "ListAgentEntities_CursorPaginated",
                                methodName: "ListAgentEntities_CursorPaginatedAsync",
                                pathTemplate: "\"/v1/agents/pages\"",
                                httpMethod: "GET",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: true,
                                retryDelay: __retryDelay,
                                retryReason: "status:" + ((int)__response.StatusCode).ToString(global::System.Globalization.CultureInfo.InvariantCulture),
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                        __response.Dispose();
                        __response = null;
                        __httpRequest.Dispose();
                        __httpRequest = null;
                        await global::Mistral.AutoSDKRequestOptionsSupport.DelayBeforeRetryAsync(
                            retryDelay: __retryDelay,
                            cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                        continue;
                    }

                    break;
                }

                if (__response == null)
                {
                    throw new global::System.InvalidOperationException("No response received.");
                }

                using (__response)
                {

                ProcessResponse(
                    client: HttpClient,
                    response: __response);
                ProcessListAgentEntities_CursorPaginatedResponse(
                    httpClient: HttpClient,
                    httpResponseMessage: __response);
                if (__response.IsSuccessStatusCode)
                {
                    await global::Mistral.AutoSDKRequestOptionsSupport.OnAfterSuccessAsync(
                            clientOptions: Options,
                            context: global::Mistral.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "ListAgentEntities_CursorPaginated",
                                methodName: "ListAgentEntities_CursorPaginatedAsync",
                                pathTemplate: "\"/v1/agents/pages\"",
                                httpMethod: "GET",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attemptNumber,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                retryDelay: null,
                                retryReason: global::System.String.Empty,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                }
                else
                {
                    await global::Mistral.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::Mistral.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "ListAgentEntities_CursorPaginated",
                                methodName: "ListAgentEntities_CursorPaginatedAsync",
                                pathTemplate: "\"/v1/agents/pages\"",
                                httpMethod: "GET",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attemptNumber,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                retryDelay: null,
                                retryReason: global::System.String.Empty,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                }
                            // Validation Error
                            if ((int)__response.StatusCode == 422)
                            {
                                string? __content_422 = null;
                                global::System.Exception? __exception_422 = null;
                                global::Mistral.HTTPValidationError? __value_422 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_422 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_422 = global::Mistral.HTTPValidationError.FromJson(__content_422, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_422 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_422 = global::Mistral.HTTPValidationError.FromJson(__content_422, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_422 = __ex;
                                }


                                throw global::Mistral.ApiException<global::Mistral.HTTPValidationError>.Create(
                                    statusCode: __response.StatusCode,
                                    message: __content_422 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_422,
                                    responseBody: __content_422,
                                    responseObject: __value_422,
                                    responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value));
                            }

                            if (__effectiveReadResponseAsString)
                            {
                                var __content = await __response.Content.ReadAsStringAsync(
                #if NET5_0_OR_GREATER
                                    __effectiveCancellationToken
                #endif
                                ).ConfigureAwait(false);

                                ProcessResponseContent(
                                    client: HttpClient,
                                    response: __response,
                                    content: ref __content);
                                ProcessListAgentEntities_CursorPaginatedResponseContent(
                                    httpClient: HttpClient,
                                    httpResponseMessage: __response,
                                    content: ref __content);

                                try
                                {
                                    __response.EnsureSuccessStatusCode();

                                    var __value = global::Mistral.AgentListPage.FromJson(__content, JsonSerializerContext) ??
                                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
                                    return new global::Mistral.AutoSDKHttpResponse<global::Mistral.AgentListPage>(
                                        statusCode: __response.StatusCode,
                                        headers: global::Mistral.AutoSDKHttpResponse.CreateHeaders(__response),
                                        requestUri: __response.RequestMessage?.RequestUri,
                                        body: __value);
                                }
                                catch (global::System.Exception __ex)
                                {
                                    throw global::Mistral.ApiException.Create(
                                        statusCode: __response.StatusCode,
                                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                                        innerException: __ex,
                                        responseBody: __content,
                                        responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                            __response.Headers,
                                            h => h.Key,
                                            h => h.Value));
                                }
                            }
                            else
                            {
                                try
                                {
                                    __response.EnsureSuccessStatusCode();
                                    using var __content = await __response.Content.ReadAsStreamAsync(
                #if NET5_0_OR_GREATER
                                        __effectiveCancellationToken
                #endif
                                    ).ConfigureAwait(false);

                                    var __value = await global::Mistral.AgentListPage.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
                                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                                    return new global::Mistral.AutoSDKHttpResponse<global::Mistral.AgentListPage>(
                                        statusCode: __response.StatusCode,
                                        headers: global::Mistral.AutoSDKHttpResponse.CreateHeaders(__response),
                                        requestUri: __response.RequestMessage?.RequestUri,
                                        body: __value);
                                }
                                catch (global::System.Exception __ex)
                                {
                                    string? __content = null;
                                    try
                                    {
                                        __content = await __response.Content.ReadAsStringAsync(
                #if NET5_0_OR_GREATER
                                            __effectiveCancellationToken
                #endif
                                        ).ConfigureAwait(false);
                                    }
                                    catch (global::System.Exception)
                                    {
                                    }

                                    throw global::Mistral.ApiException.Create(
                                        statusCode: __response.StatusCode,
                                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                                        innerException: __ex,
                                        responseBody: __content,
                                        responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                            __response.Headers,
                                            h => h.Key,
                                            h => h.Value));
                                }
                            }

                }
            }
            finally
            {
                __httpRequest?.Dispose();
            }
        }

        /// <summary>
        /// Wraps ListAgentEntities_CursorPaginatedAsync as an IAsyncEnumerable&lt;global::Mistral.Agent&gt; that auto-pages over the response.
        /// </summary>
        /// <param name="pageSize">
        /// Number of agents per page<br/>
        /// Default Value: 20
        /// </param>
        /// <param name="deploymentChat"></param>
        /// <param name="sources"></param>
        /// <param name="name">
        /// Filter by agent name
        /// </param>
        /// <param name="search">
        /// Search agents by name or ID
        /// </param>
        /// <param name="id"></param>
        /// <param name="metadata"></param> 
        /// <param name="pageToken">Initial cursor to start enumerating from. Defaults to null (first page).</param>
        /// <param name="cancellationToken"></param>
        public global::System.Collections.Generic.IAsyncEnumerable<global::Mistral.Agent> ListAgentEntities_CursorPaginatedAutoPagingAsync(
              int? pageSize = default,
            bool? deploymentChat = default,
            global::System.Collections.Generic.IList<global::Mistral.RequestSource>? sources = default,
            string? name = default,
            string? search = default,
            string? id = default,
            object? metadata = default,
            string? pageToken = null,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            return global::Mistral.AutoSDKPager.CursorAsync<global::Mistral.AgentListPage, global::Mistral.Agent>(
                fetchPage: (__cursor, __ct) => ListAgentEntities_CursorPaginatedAsync(
                    pageSize: pageSize,
                    deploymentChat: deploymentChat,
                    sources: sources,
                    name: name,
                    search: search,
                    id: id,
                    pageToken: __cursor,
                    metadata: metadata,
                    cancellationToken: __ct),
                extractItems: static __response => __response is null
                    ? null
                    : (global::System.Collections.Generic.IEnumerable<global::Mistral.Agent>?)__response.Data,
                extractNextCursor: static __response => __response is null ? null : __response.NextPageToken,
                initialCursor: pageToken,
                cancellationToken: cancellationToken);
        }

    }
}