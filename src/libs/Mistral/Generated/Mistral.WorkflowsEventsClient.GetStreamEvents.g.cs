
#nullable enable

namespace Mistral
{
    public partial class WorkflowsEventsClient
    {


        private static readonly global::Mistral.EndPointSecurityRequirement s_GetStreamEventsSecurityRequirement0 =
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
        private static readonly global::Mistral.EndPointSecurityRequirement[] s_GetStreamEventsSecurityRequirements =
            new global::Mistral.EndPointSecurityRequirement[]
            {                s_GetStreamEventsSecurityRequirement0,
            };
        partial void PrepareGetStreamEventsArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref global::Mistral.GetStreamEventsV1WorkflowsEventsStreamGetScope? scope,
            ref string? activityName,
            ref string? activityId,
            ref string? workflowName,
            ref string? workflowExecId,
            ref string? rootWorkflowExecId,
            ref string? parentWorkflowExecId,
            ref string? stream,
            ref int? startSeq,
            object? metadataFilters,
            global::System.Collections.Generic.IList<global::Mistral.WorkflowEventType>? workflowEventTypes,
            ref string? lastEventId);
        partial void PrepareGetStreamEventsRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::Mistral.GetStreamEventsV1WorkflowsEventsStreamGetScope? scope,
            string? activityName,
            string? activityId,
            string? workflowName,
            string? workflowExecId,
            string? rootWorkflowExecId,
            string? parentWorkflowExecId,
            string? stream,
            int? startSeq,
            object? metadataFilters,
            global::System.Collections.Generic.IList<global::Mistral.WorkflowEventType>? workflowEventTypes,
            string? lastEventId);
        partial void ProcessGetStreamEventsResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        /// <summary>
        /// Get Stream Events
        /// </summary>
        /// <param name="scope">
        /// Default Value: *
        /// </param>
        /// <param name="activityName">
        /// Default Value: *
        /// </param>
        /// <param name="activityId">
        /// Default Value: *
        /// </param>
        /// <param name="workflowName">
        /// Default Value: *
        /// </param>
        /// <param name="workflowExecId">
        /// Default Value: *
        /// </param>
        /// <param name="rootWorkflowExecId">
        /// Default Value: *
        /// </param>
        /// <param name="parentWorkflowExecId">
        /// Default Value: *
        /// </param>
        /// <param name="stream">
        /// Default Value: *
        /// </param>
        /// <param name="startSeq">
        /// Default Value: 0
        /// </param>
        /// <param name="metadataFilters"></param>
        /// <param name="workflowEventTypes"></param>
        /// <param name="lastEventId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mistral.ApiException"></exception>
        public async global::System.Collections.Generic.IAsyncEnumerable<global::Mistral.GetStreamEventsV1WorkflowsEventsStreamGetResponse> GetStreamEventsAsync(
            global::Mistral.GetStreamEventsV1WorkflowsEventsStreamGetScope? scope = default,
            string? activityName = default,
            string? activityId = default,
            string? workflowName = default,
            string? workflowExecId = default,
            string? rootWorkflowExecId = default,
            string? parentWorkflowExecId = default,
            string? stream = default,
            int? startSeq = default,
            object? metadataFilters = default,
            global::System.Collections.Generic.IList<global::Mistral.WorkflowEventType>? workflowEventTypes = default,
            string? lastEventId = default,
            global::Mistral.AutoSDKRequestOptions? requestOptions = default,
            [global::System.Runtime.CompilerServices.EnumeratorCancellation] global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareGetStreamEventsArguments(
                httpClient: HttpClient,
                scope: ref scope,
                activityName: ref activityName,
                activityId: ref activityId,
                workflowName: ref workflowName,
                workflowExecId: ref workflowExecId,
                rootWorkflowExecId: ref rootWorkflowExecId,
                parentWorkflowExecId: ref parentWorkflowExecId,
                stream: ref stream,
                startSeq: ref startSeq,
                metadataFilters: metadataFilters,
                workflowEventTypes: workflowEventTypes,
                lastEventId: ref lastEventId);


            var __authorizations = global::Mistral.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_GetStreamEventsSecurityRequirements,
                operationName: "GetStreamEventsAsync");

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
                                path: "/v1/workflows/events/stream",
                                baseUri: HttpClient.BaseAddress); 
                            __pathBuilder
                                .AddOptionalParameter("scope", scope?.ToValueString())
                                .AddOptionalParameter("activity_name", activityName)
                                .AddOptionalParameter("activity_id", activityId)
                                .AddOptionalParameter("workflow_name", workflowName)
                                .AddOptionalParameter("workflow_exec_id", workflowExecId)
                                .AddOptionalParameter("root_workflow_exec_id", rootWorkflowExecId)
                                .AddOptionalParameter("parent_workflow_exec_id", parentWorkflowExecId)
                                .AddOptionalParameter("stream", stream)
                                .AddOptionalParameter("start_seq", startSeq?.ToString())
                                .AddOptionalParameter("metadata_filters", metadataFilters?.ToString())
                                .AddOptionalParameter("workflow_event_types", workflowEventTypes?.ToString()) 
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

                if (lastEventId != default)
                {
                    __httpRequest.Headers.TryAddWithoutValidation("last-event-id", lastEventId.ToString());
                }

                global::Mistral.AutoSDKRequestOptionsSupport.ApplyHeaders(
                    request: __httpRequest,
                    clientHeaders: Options.Headers,
                    requestHeaders: requestOptions?.Headers);

                PrepareRequest(
                    client: HttpClient,
                    request: __httpRequest);
                PrepareGetStreamEventsRequest(
                    httpClient: HttpClient,
                    httpRequestMessage: __httpRequest,
                    scope: scope,
                    activityName: activityName,
                    activityId: activityId,
                    workflowName: workflowName,
                    workflowExecId: workflowExecId,
                    rootWorkflowExecId: rootWorkflowExecId,
                    parentWorkflowExecId: parentWorkflowExecId,
                    stream: stream,
                    startSeq: startSeq,
                    metadataFilters: metadataFilters,
                    workflowEventTypes: workflowEventTypes,
                    lastEventId: lastEventId);

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
                                operationId: "GetStreamEvents",
                                methodName: "GetStreamEventsAsync",
                                pathTemplate: "\"/v1/workflows/events/stream\"",
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
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                    try
                    {
                        __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseHeadersRead,
                cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                    }
                    catch (global::System.Net.Http.HttpRequestException __exception)
                    {
                        var __willRetry = __attempt < __maxAttempts && !__effectiveCancellationToken.IsCancellationRequested;
                        await global::Mistral.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::Mistral.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "GetStreamEvents",
                                methodName: "GetStreamEventsAsync",
                                pathTemplate: "\"/v1/workflows/events/stream\"",
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
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                        if (!__willRetry)
                        {
                            throw;
                        }

                        __httpRequest.Dispose();
                        __httpRequest = null;
                        await global::Mistral.AutoSDKRequestOptionsSupport.DelayBeforeRetryAsync(
                            clientOptions: Options,
                            requestOptions: requestOptions,
                            cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                        continue;
                    }

                    if (__response != null &&
                        __attempt < __maxAttempts &&
                        global::Mistral.AutoSDKRequestOptionsSupport.ShouldRetryStatusCode(__response.StatusCode))
                    {
                        await global::Mistral.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::Mistral.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "GetStreamEvents",
                                methodName: "GetStreamEventsAsync",
                                pathTemplate: "\"/v1/workflows/events/stream\"",
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
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                        __response.Dispose();
                        __response = null;
                        __httpRequest.Dispose();
                        __httpRequest = null;
                        await global::Mistral.AutoSDKRequestOptionsSupport.DelayBeforeRetryAsync(
                            clientOptions: Options,
                            requestOptions: requestOptions,
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
                ProcessGetStreamEventsResponse(
                    httpClient: HttpClient,
                    httpResponseMessage: __response);
                if (__response.IsSuccessStatusCode)
                {
                    await global::Mistral.AutoSDKRequestOptionsSupport.OnAfterSuccessAsync(
                            clientOptions: Options,
                            context: global::Mistral.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "GetStreamEvents",
                                methodName: "GetStreamEventsAsync",
                                pathTemplate: "\"/v1/workflows/events/stream\"",
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
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                }
                else
                {
                    await global::Mistral.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::Mistral.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "GetStreamEvents",
                                methodName: "GetStreamEventsAsync",
                                pathTemplate: "\"/v1/workflows/events/stream\"",
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
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                }

                            try
                            {
                                __response.EnsureSuccessStatusCode();
                            }
                            catch (global::System.Net.Http.HttpRequestException __ex)
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

                            using var __stream = await __response.Content.ReadAsStreamAsync(
                #if NET5_0_OR_GREATER
                                __effectiveCancellationToken
                #endif
                            ).ConfigureAwait(false);

                            await foreach (var __sseEvent in global::System.Net.ServerSentEvents.SseParser
                                .Create(__stream).EnumerateAsync(__effectiveCancellationToken))
                            {
                                var __content = __sseEvent.Data;
                                if (__content == "[DONE]")
                                {
                                    yield break;
                                }

                                var __streamedResponse = global::Mistral.GetStreamEventsV1WorkflowsEventsStreamGetResponse.FromJson(__content, JsonSerializerContext) ??
                                                       throw new global::Mistral.ApiException(
                                                           message: $"Response deserialization failed for \"{__content}\" ",
                                                           statusCode: __response.StatusCode)
                                                       {
                                                           ResponseBody = __content,
                                                           ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                                                               __response.Headers,
                                                               h => h.Key,
                                                               h => h.Value),
                                                       };

                                yield return __streamedResponse;
                            }

                }
            }
            finally
            {
                __httpRequest?.Dispose();
            }
        }
    }
}