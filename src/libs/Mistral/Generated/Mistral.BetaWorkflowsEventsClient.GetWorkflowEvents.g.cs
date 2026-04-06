
#nullable enable

namespace Mistral
{
    public partial class BetaWorkflowsEventsClient
    {
        partial void PrepareGetWorkflowEventsArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string? rootWorkflowExecId,
            ref string? workflowExecId,
            ref string? workflowRunId,
            ref int? limit,
            ref string? cursor);
        partial void PrepareGetWorkflowEventsRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string? rootWorkflowExecId,
            string? workflowExecId,
            string? workflowRunId,
            int? limit,
            string? cursor);
        partial void ProcessGetWorkflowEventsResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessGetWorkflowEventsResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Get Workflow Events
        /// </summary>
        /// <param name="rootWorkflowExecId">
        /// Execution ID of the root workflow that initiated this execution chain.
        /// </param>
        /// <param name="workflowExecId">
        /// Execution ID of the workflow that emitted this event.
        /// </param>
        /// <param name="workflowRunId">
        /// Run ID of the workflow that emitted this event.
        /// </param>
        /// <param name="limit">
        /// Maximum number of events to return.<br/>
        /// Default Value: 100
        /// </param>
        /// <param name="cursor">
        /// Cursor for pagination.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mistral.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::Mistral.ListWorkflowEventResponse> GetWorkflowEventsAsync(
            string? rootWorkflowExecId = default,
            string? workflowExecId = default,
            string? workflowRunId = default,
            int? limit = default,
            string? cursor = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareGetWorkflowEventsArguments(
                httpClient: HttpClient,
                rootWorkflowExecId: ref rootWorkflowExecId,
                workflowExecId: ref workflowExecId,
                workflowRunId: ref workflowRunId,
                limit: ref limit,
                cursor: ref cursor);

            var __pathBuilder = new global::Mistral.PathBuilder(
                path: "/v1/workflows/events/list",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder
                .AddOptionalParameter("root_workflow_exec_id", rootWorkflowExecId)
                .AddOptionalParameter("workflow_exec_id", workflowExecId)
                .AddOptionalParameter("workflow_run_id", workflowRunId)
                .AddOptionalParameter("limit", limit?.ToString())
                .AddOptionalParameter("cursor", cursor) 
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
            PrepareGetWorkflowEventsRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                rootWorkflowExecId: rootWorkflowExecId,
                workflowExecId: workflowExecId,
                workflowRunId: workflowRunId,
                limit: limit,
                cursor: cursor);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessGetWorkflowEventsResponse(
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
                        __value_422 = global::Mistral.HTTPValidationError.FromJson(__content_422, JsonSerializerContext);
                    }
                    else
                    {
                        __content_422 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_422 = global::Mistral.HTTPValidationError.FromJson(__content_422, JsonSerializerContext);
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
                ProcessGetWorkflowEventsResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::Mistral.ListWorkflowEventResponse.FromJson(__content, JsonSerializerContext) ??
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
                        await global::Mistral.ListWorkflowEventResponse.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
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