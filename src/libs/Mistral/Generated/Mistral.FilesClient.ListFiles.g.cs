
#nullable enable

namespace Mistral
{
    public partial class FilesClient
    {
        partial void PrepareListFilesArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref int? page,
            ref int? pageSize,
            global::System.Collections.Generic.IList<global::Mistral.SampleType>? sampleType,
            global::System.Collections.Generic.IList<global::Mistral.Source>? source,
            ref string? search,
            object? purpose);
        partial void PrepareListFilesRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            int? page,
            int? pageSize,
            global::System.Collections.Generic.IList<global::Mistral.SampleType>? sampleType,
            global::System.Collections.Generic.IList<global::Mistral.Source>? source,
            string? search,
            object? purpose);
        partial void ProcessListFilesResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessListFilesResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// List Files<br/>
        /// Returns a list of files that belong to the user's organization.
        /// </summary>
        /// <param name="page">
        /// Default Value: 0
        /// </param>
        /// <param name="pageSize">
        /// Default Value: 100
        /// </param>
        /// <param name="sampleType"></param>
        /// <param name="source"></param>
        /// <param name="search"></param>
        /// <param name="purpose"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::Mistral.ListFilesOut> ListFilesAsync(
            int? page = default,
            int? pageSize = default,
            global::System.Collections.Generic.IList<global::Mistral.SampleType>? sampleType = default,
            global::System.Collections.Generic.IList<global::Mistral.Source>? source = default,
            string? search = default,
            object? purpose = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareListFilesArguments(
                httpClient: HttpClient,
                page: ref page,
                pageSize: ref pageSize,
                sampleType: sampleType,
                source: source,
                search: ref search,
                purpose: purpose);

            var __pathBuilder = new PathBuilder(
                path: "/v1/files",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder 
                .AddOptionalParameter("page", page?.ToString()) 
                .AddOptionalParameter("page_size", pageSize?.ToString()) 
                .AddOptionalParameter("search", search) 
                .AddOptionalParameter("purpose", purpose?.ToString()) 
                ; 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));

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
            PrepareListFilesRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                page: page,
                pageSize: pageSize,
                sampleType: sampleType,
                source: source,
                search: search,
                purpose: purpose);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessListFilesResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);

            var __content = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: HttpClient,
                response: __response,
                content: ref __content);
            ProcessListFilesResponseContent(
                httpClient: HttpClient,
                httpResponseMessage: __response,
                content: ref __content);

            try
            {
                __response.EnsureSuccessStatusCode();
            }
            catch (global::System.Net.Http.HttpRequestException __ex)
            {
                throw new global::System.InvalidOperationException(__content, __ex);
            }

            return
                global::Mistral.ListFilesOut.FromJson(__content, JsonSerializerContext) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}