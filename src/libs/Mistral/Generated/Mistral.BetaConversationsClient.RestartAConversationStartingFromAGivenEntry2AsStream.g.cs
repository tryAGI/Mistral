
#nullable enable

namespace Mistral
{
    public partial class BetaConversationsClient
    {
        partial void PrepareRestartAConversationStartingFromAGivenEntry2AsStreamArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string conversationId,
            global::Mistral.ConversationRestartStreamRequest request);
        partial void PrepareRestartAConversationStartingFromAGivenEntry2AsStreamRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string conversationId,
            global::Mistral.ConversationRestartStreamRequest request);
        partial void ProcessRestartAConversationStartingFromAGivenEntry2AsStreamResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        /// <summary>
        /// Restart a conversation starting from a given entry.<br/>
        /// Given a conversation_id and an id, recreate a conversation from this point and run completion. A new conversation is returned with the new entries returned.
        /// </summary>
        /// <param name="conversationId">
        /// ID of the original conversation which is being restarted.
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mistral.ApiException"></exception>
        public async global::System.Collections.Generic.IAsyncEnumerable<global::Mistral.ConversationEvents> RestartAConversationStartingFromAGivenEntry2AsStreamAsync(
            string conversationId,

            global::Mistral.ConversationRestartStreamRequest request,
            [global::System.Runtime.CompilerServices.EnumeratorCancellation] global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareRestartAConversationStartingFromAGivenEntry2AsStreamArguments(
                httpClient: HttpClient,
                conversationId: ref conversationId,
                request: request);

            var __pathBuilder = new global::Mistral.PathBuilder(
                path: $"/v1/conversations/{conversationId}/restart#stream",
                baseUri: HttpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
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
            var __httpRequestContentBody = request.ToJson(JsonSerializerContext);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            __httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareRestartAConversationStartingFromAGivenEntry2AsStreamRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                conversationId: conversationId,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseHeadersRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessRestartAConversationStartingFromAGivenEntry2AsStreamResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);

            try
            {
                __response.EnsureSuccessStatusCode();
            }
            catch (global::System.Net.Http.HttpRequestException __ex)
            {
                throw new global::Mistral.ApiException(
                    message: __response.ReasonPhrase ?? string.Empty,
                    innerException: __ex,
                    statusCode: __response.StatusCode)
                {
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

                var __streamedResponse = global::Mistral.ConversationEvents.FromJson(__content, JsonSerializerContext) ??
                                       throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");

                yield return __streamedResponse;
            }
        }

        /// <summary>
        /// Restart a conversation starting from a given entry.<br/>
        /// Given a conversation_id and an id, recreate a conversation from this point and run completion. A new conversation is returned with the new entries returned.
        /// </summary>
        /// <param name="conversationId">
        /// ID of the original conversation which is being restarted.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Collections.Generic.IAsyncEnumerable<global::Mistral.ConversationEvents> RestartAConversationStartingFromAGivenEntry2AsStreamAsync(
            string conversationId,
            [global::System.Runtime.CompilerServices.EnumeratorCancellation] global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::Mistral.ConversationRestartStreamRequest
            {
            };

            var __enumerable = RestartAConversationStartingFromAGivenEntry2AsStreamAsync(
                conversationId: conversationId,
                request: __request,
                cancellationToken: cancellationToken);

            await foreach (var __response in __enumerable)
            {
                yield return __response;
            }
        }
    }
}