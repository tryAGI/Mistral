
#nullable enable

namespace Mistral
{
    public partial class BetaWorkflowsClient
    {
        partial void PrepareGetWorkflowRegistrationsArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Guid? workflowId,
            ref string? taskQueue,
            ref bool? activeOnly,
            ref bool? includeShared,
            ref string? workflowSearch,
            bool? archived,
            ref bool? withWorkflow,
            bool? availableInChatAssistant,
            ref int? limit,
            global::System.Guid? cursor);
        partial void PrepareGetWorkflowRegistrationsRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::System.Guid? workflowId,
            string? taskQueue,
            bool? activeOnly,
            bool? includeShared,
            string? workflowSearch,
            bool? archived,
            bool? withWorkflow,
            bool? availableInChatAssistant,
            int? limit,
            global::System.Guid? cursor);
        partial void ProcessGetWorkflowRegistrationsResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessGetWorkflowRegistrationsResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Get Workflow Registrations
        /// </summary>
        /// <param name="workflowId">
        /// The workflow ID to filter by
        /// </param>
        /// <param name="taskQueue">
        /// The task queue to filter by
        /// </param>
        /// <param name="activeOnly">
        /// Whether to only return active workflows versions<br/>
        /// Default Value: false
        /// </param>
        /// <param name="includeShared">
        /// Whether to include shared workflow versions<br/>
        /// Default Value: true
        /// </param>
        /// <param name="workflowSearch">
        /// The workflow name to filter by
        /// </param>
        /// <param name="archived">
        /// Filter by archived state. False=exclude archived, True=only archived, None=include all
        /// </param>
        /// <param name="withWorkflow">
        /// Whether to include the workflow definition<br/>
        /// Default Value: false
        /// </param>
        /// <param name="availableInChatAssistant">
        /// Whether to only return workflows compatible with chat assistant
        /// </param>
        /// <param name="limit">
        /// The maximum number of workflows versions to return<br/>
        /// Default Value: 50
        /// </param>
        /// <param name="cursor">
        /// The cursor for pagination
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mistral.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::Mistral.WorkflowRegistrationListResponse> GetWorkflowRegistrationsAsync(
            global::System.Guid? workflowId = default,
            string? taskQueue = default,
            bool? activeOnly = default,
            bool? includeShared = default,
            string? workflowSearch = default,
            bool? archived = default,
            bool? withWorkflow = default,
            bool? availableInChatAssistant = default,
            int? limit = default,
            global::System.Guid? cursor = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareGetWorkflowRegistrationsArguments(
                httpClient: HttpClient,
                workflowId: workflowId,
                taskQueue: ref taskQueue,
                activeOnly: ref activeOnly,
                includeShared: ref includeShared,
                workflowSearch: ref workflowSearch,
                archived: archived,
                withWorkflow: ref withWorkflow,
                availableInChatAssistant: availableInChatAssistant,
                limit: ref limit,
                cursor: cursor);

            var __pathBuilder = new global::Mistral.PathBuilder(
                path: "/v1/workflows/registrations",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder
                .AddOptionalParameter("workflow_id", workflowId?.ToString())
                .AddOptionalParameter("task_queue", taskQueue)
                .AddOptionalParameter("active_only", activeOnly?.ToString().ToLowerInvariant())
                .AddOptionalParameter("include_shared", includeShared?.ToString().ToLowerInvariant())
                .AddOptionalParameter("workflow_search", workflowSearch)
                .AddOptionalParameter("archived", archived?.ToString().ToLowerInvariant())
                .AddOptionalParameter("with_workflow", withWorkflow?.ToString().ToLowerInvariant())
                .AddOptionalParameter("available_in_chat_assistant", availableInChatAssistant?.ToString().ToLowerInvariant())
                .AddOptionalParameter("limit", limit?.ToString())
                .AddOptionalParameter("cursor", cursor?.ToString()) 
                ; 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
            __httpRequest.Version = global::System.Net.HttpVersion.Version11;
            __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

            foreach (var __authorization in Authorizations)
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

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareGetWorkflowRegistrationsRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                workflowId: workflowId,
                taskQueue: taskQueue,
                activeOnly: activeOnly,
                includeShared: includeShared,
                workflowSearch: workflowSearch,
                archived: archived,
                withWorkflow: withWorkflow,
                availableInChatAssistant: availableInChatAssistant,
                limit: limit,
                cursor: cursor);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessGetWorkflowRegistrationsResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);
            // Validation Error
            if ((int)__response.StatusCode == 422)
            {
                string? __content_422 = null;
                global::System.Exception? __exception_422 = null;
                global::Mistral.HTTPValidationError? __value_422 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_422 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_422 = global::Mistral.HTTPValidationError.FromJson(__content_422, JsonSerializerOptions);
                    }
                    else
                    {
                        __content_422 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_422 = global::Mistral.HTTPValidationError.FromJson(__content_422, JsonSerializerOptions);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_422 = __ex;
                }

                throw new global::Mistral.ApiException<global::Mistral.HTTPValidationError>(
                    message: __content_422 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_422,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_422,
                    ResponseObject = __value_422,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }

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
                ProcessGetWorkflowRegistrationsResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::Mistral.WorkflowRegistrationListResponse.FromJson(__content, JsonSerializerOptions) ??
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
                        await global::Mistral.WorkflowRegistrationListResponse.FromJsonStreamAsync(__content, JsonSerializerOptions).ConfigureAwait(false) ??
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
    }
}