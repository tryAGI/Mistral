
#nullable enable

namespace Mistral
{
    public partial class BetaWorkflowsEventsClient
    {
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

            if (lastEventId != default)
            {
                __httpRequest.Headers.TryAddWithoutValidation("last-event-id", lastEventId.ToString());
            }


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

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseHeadersRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessGetStreamEventsResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);

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

            using var __stream = await __response.Content.ReadAsStreamAsync(
#if NET5_0_OR_GREATER
                cancellationToken
#endif
            ).ConfigureAwait(false);

            await foreach (var __sseEvent in global::System.Net.ServerSentEvents.SseParser
                .Create(__stream).EnumerateAsync(cancellationToken))
            {
                var __content = __sseEvent.Data;
                if (__content == "[DONE]")
                {
                    yield break;
                }

                var __streamedResponse = global::Mistral.GetStreamEventsV1WorkflowsEventsStreamGetResponse.FromJson(__content, JsonSerializerOptions) ??
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
}