
#nullable enable

namespace Mistral
{
    public partial class BetaWorkflowsMetricsClient
    {
        partial void PrepareGetWorkflowMetricsArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string workflowName,
            global::System.DateTime? startTime,
            global::System.DateTime? endTime);
        partial void PrepareGetWorkflowMetricsRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string workflowName,
            global::System.DateTime? startTime,
            global::System.DateTime? endTime);
        partial void ProcessGetWorkflowMetricsResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessGetWorkflowMetricsResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Get Workflow Metrics<br/>
        /// Get comprehensive metrics for a specific workflow.<br/>
        /// Args:<br/>
        ///     workflow_name: The name of the workflow type to get metrics for<br/>
        ///     start_time: Optional start time filter (ISO 8601 format)<br/>
        ///     end_time: Optional end time filter (ISO 8601 format)<br/>
        /// Returns:<br/>
        ///     WorkflowMetrics: Dictionary containing metrics:<br/>
        ///         - execution_count: Total number of executions<br/>
        ///         - success_count: Number of successful executions<br/>
        ///         - error_count: Number of failed/terminated executions<br/>
        ///         - average_latency_ms: Average execution duration in milliseconds<br/>
        ///         - retry_rate: Proportion of workflows with retries<br/>
        ///         - latency_over_time: Time-series data of execution durations<br/>
        /// Example:<br/>
        ///     GET /v1/workflows/MyWorkflow/metrics<br/>
        ///     GET /v1/workflows/MyWorkflow/metrics?start_time=2025-01-01T00:00:00Z<br/>
        ///     GET /v1/workflows/MyWorkflow/metrics?start_time=2025-01-01T00:00:00Z&amp;end_time=2025-12-31T23:59:59Z
        /// </summary>
        /// <param name="workflowName"></param>
        /// <param name="startTime">
        /// Filter workflows started after this time (ISO 8601)
        /// </param>
        /// <param name="endTime">
        /// Filter workflows started before this time (ISO 8601)
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mistral.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::Mistral.WorkflowMetrics> GetWorkflowMetricsAsync(
            string workflowName,
            global::System.DateTime? startTime = default,
            global::System.DateTime? endTime = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareGetWorkflowMetricsArguments(
                httpClient: HttpClient,
                workflowName: ref workflowName,
                startTime: startTime,
                endTime: endTime);

            var __pathBuilder = new global::Mistral.PathBuilder(
                path: $"/v1/workflows/{workflowName}/metrics",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder
                .AddOptionalParameter("start_time", startTime?.ToString())
                .AddOptionalParameter("end_time", endTime?.ToString()) 
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
            PrepareGetWorkflowMetricsRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                workflowName: workflowName,
                startTime: startTime,
                endTime: endTime);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessGetWorkflowMetricsResponse(
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
                ProcessGetWorkflowMetricsResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::Mistral.WorkflowMetrics.FromJson(__content, JsonSerializerContext) ??
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
                        await global::Mistral.WorkflowMetrics.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
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