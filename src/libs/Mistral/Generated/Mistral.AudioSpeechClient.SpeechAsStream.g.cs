
#nullable enable

namespace Mistral
{
    public partial class AudioSpeechClient
    {


        private static readonly global::Mistral.EndPointSecurityRequirement s_SpeechAsStreamSecurityRequirement0 =
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
        private static readonly global::Mistral.EndPointSecurityRequirement[] s_SpeechAsStreamSecurityRequirements =
            new global::Mistral.EndPointSecurityRequirement[]
            {                s_SpeechAsStreamSecurityRequirement0,
            };
        partial void PrepareSpeechAsStreamArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::Mistral.SpeechRequest request);
        partial void PrepareSpeechAsStreamRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::Mistral.SpeechRequest request);
        partial void ProcessSpeechAsStreamResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        /// <summary>
        /// Speech<br/>
        /// Generate speech from text using a saved voice or a reference audio clip.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mistral.ApiException"></exception>
        public async global::System.Collections.Generic.IAsyncEnumerable<global::Mistral.SpeechStreamEvents> SpeechAsStreamAsync(

            global::Mistral.SpeechRequest request,
            [global::System.Runtime.CompilerServices.EnumeratorCancellation] global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            request = new global::Mistral.SpeechRequest
            {
                Model = request.Model,
                Stream = true,
                VoiceId = request.VoiceId,
                RefAudio = request.RefAudio,
                Input = request.Input,
                ResponseFormat = request.ResponseFormat,
            };
            PrepareArguments(
                client: HttpClient);
            PrepareSpeechAsStreamArguments(
                httpClient: HttpClient,
                request: request);


            var __authorizations = global::Mistral.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_SpeechAsStreamSecurityRequirements,
                operationName: "SpeechAsStreamAsync");

            var __pathBuilder = new global::Mistral.PathBuilder(
                path: "/v1/audio/speech",
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
            PrepareSpeechAsStreamRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseHeadersRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessSpeechAsStreamResponse(
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

                var __streamedResponse = global::Mistral.SpeechStreamEvents.FromJson(__content, JsonSerializerContext) ??
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
        /// <summary>
        /// Speech<br/>
        /// Generate speech from text using a saved voice or a reference audio clip.
        /// </summary>
        /// <param name="model"></param>
        /// <param name="voiceId">
        /// The preset or custom voice to use for generating the speech.
        /// </param>
        /// <param name="refAudio">
        /// The base64-encoded audio reference for zero-shot voice cloning.
        /// </param>
        /// <param name="input">
        /// Text to generate speech from.
        /// </param>
        /// <param name="responseFormat">
        /// Output audio format. Defaults to mp3.<br/>
        /// Default Value: mp3
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Collections.Generic.IAsyncEnumerable<global::Mistral.SpeechStreamEvents> SpeechAsStreamAsync(
            string input,
            string? model = default,
            string? voiceId = default,
            string? refAudio = default,
            global::Mistral.SpeechOutputFormat? responseFormat = default,
            [global::System.Runtime.CompilerServices.EnumeratorCancellation] global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::Mistral.SpeechRequest
            {
                Model = model,
                Stream = true,
                VoiceId = voiceId,
                RefAudio = refAudio,
                Input = input,
                ResponseFormat = responseFormat,
            };

            var __enumerable = SpeechAsStreamAsync(
                request: __request,
                cancellationToken: cancellationToken);

            await foreach (var __response in __enumerable)
            {
                yield return __response;
            }
        }
    }
}