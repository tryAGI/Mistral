
#nullable enable

namespace Mistral
{
    public partial class AudioTranscriptionsClient
    {
        partial void PrepareCreateStreamingTranscriptionSSEArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::Mistral.AudioTranscriptionRequestStream request);
        partial void PrepareCreateStreamingTranscriptionSSERequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::Mistral.AudioTranscriptionRequestStream request);
        partial void ProcessCreateStreamingTranscriptionSSEResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessCreateStreamingTranscriptionSSEResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Create streaming transcription (SSE)
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mistral.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::Mistral.TranscriptionStreamEvents> CreateStreamingTranscriptionSSEAsync(
            global::Mistral.AudioTranscriptionRequestStream request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareCreateStreamingTranscriptionSSEArguments(
                httpClient: HttpClient,
                request: request);

            var __pathBuilder = new global::Mistral.PathBuilder(
                path: "/v1/audio/transcriptions#stream",
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
            using var __httpRequestContent = new global::System.Net.Http.MultipartFormDataContent();
            if (request.File != default)
            {
                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.File}"),
                    name: "file");
            } 
            if (request.FileId != default)
            {
                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.FileId}"),
                    name: "file_id");
            } 
            if (request.FileUrl != default)
            {
                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.FileUrl}"),
                    name: "file_url");
            } 
            if (request.Language != default)
            {
                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.Language}"),
                    name: "language");
            } 
            __httpRequestContent.Add(
                content: new global::System.Net.Http.StringContent($"{request.Model}"),
                name: "model");
            if (request.Stream != default)
            {
                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.Stream}"),
                    name: "stream");
            } 
            if (request.Temperature != default)
            {
                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.Temperature}"),
                    name: "temperature");
            } 
            if (request.TimestampGranularities != default)
            {
                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"[{string.Join(",", global::System.Linq.Enumerable.Select(request.TimestampGranularities, x => x.ToValueString()))}]"),
                    name: "timestamp_granularities");
            }
            __httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareCreateStreamingTranscriptionSSERequest(
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
            ProcessCreateStreamingTranscriptionSSEResponse(
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
                ProcessCreateStreamingTranscriptionSSEResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::Mistral.TranscriptionStreamEvents.FromJson(__content, JsonSerializerContext) ??
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
                        await global::Mistral.TranscriptionStreamEvents.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                }
                catch (global::System.Exception __ex)
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
            }
        }

        /// <summary>
        /// Create streaming transcription (SSE)
        /// </summary>
        /// <param name="file"></param>
        /// <param name="fileId">
        /// ID of a file uploaded to /v1/files
        /// </param>
        /// <param name="fileUrl">
        /// Url of a file to be transcribed
        /// </param>
        /// <param name="language">
        /// Language of the audio, e.g. 'en'. Providing the language can boost accuracy.
        /// </param>
        /// <param name="model"></param>
        /// <param name="stream">
        /// Default Value: true
        /// </param>
        /// <param name="temperature"></param>
        /// <param name="timestampGranularities">
        /// Granularities of timestamps to include in the response.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::Mistral.TranscriptionStreamEvents> CreateStreamingTranscriptionSSEAsync(
            string model,
            object? file = default,
            string? fileId = default,
            string? fileUrl = default,
            string? language = default,
            bool? stream = default,
            double? temperature = default,
            global::System.Collections.Generic.IList<global::Mistral.TimestampGranularity>? timestampGranularities = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::Mistral.AudioTranscriptionRequestStream
            {
                File = file,
                FileId = fileId,
                FileUrl = fileUrl,
                Language = language,
                Model = model,
                Stream = stream,
                Temperature = temperature,
                TimestampGranularities = timestampGranularities,
            };

            return await CreateStreamingTranscriptionSSEAsync(
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}