
#nullable enable

namespace Mistral
{
    public partial class FineTuningClient
    {
        partial void PrepareGetFineTuningJobsArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref int? page,
            ref int? pageSize,
            ref string? model,
            ref global::System.DateTime? createdAfter,
            ref bool? createdByMe,
            ref global::Mistral.JobsApiRoutesFineTuningGetFineTuningJobsStatus? status,
            ref string? wandbProject,
            ref string? wandbName,
            ref string? suffix);
        partial void PrepareGetFineTuningJobsRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            int? page,
            int? pageSize,
            string? model,
            global::System.DateTime? createdAfter,
            bool? createdByMe,
            global::Mistral.JobsApiRoutesFineTuningGetFineTuningJobsStatus? status,
            string? wandbProject,
            string? wandbName,
            string? suffix);
        partial void ProcessGetFineTuningJobsResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessGetFineTuningJobsResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Get Fine Tuning Jobs<br/>
        /// Get a list of fine-tuning jobs for your organization and user.
        /// </summary>
        /// <param name="page">
        /// Default Value: 0
        /// </param>
        /// <param name="pageSize">
        /// Default Value: 100
        /// </param>
        /// <param name="model"></param>
        /// <param name="createdAfter"></param>
        /// <param name="createdByMe">
        /// Default Value: false
        /// </param>
        /// <param name="status"></param>
        /// <param name="wandbProject"></param>
        /// <param name="wandbName"></param>
        /// <param name="suffix"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::Mistral.JobsOut> GetFineTuningJobsAsync(
            int? page = 0,
            int? pageSize = 100,
            string? model = default,
            global::System.DateTime? createdAfter = default,
            bool? createdByMe = false,
            global::Mistral.JobsApiRoutesFineTuningGetFineTuningJobsStatus? status = default,
            string? wandbProject = default,
            string? wandbName = default,
            string? suffix = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareGetFineTuningJobsArguments(
                httpClient: _httpClient,
                page: ref page,
                pageSize: ref pageSize,
                model: ref model,
                createdAfter: ref createdAfter,
                createdByMe: ref createdByMe,
                status: ref status,
                wandbProject: ref wandbProject,
                wandbName: ref wandbName,
                suffix: ref suffix);

            var __pathBuilder = new PathBuilder(
                path: "/v1/fine_tuning/jobs",
                baseUri: _httpClient.BaseAddress); 
            __pathBuilder 
                .AddOptionalParameter("page", page?.ToString()) 
                .AddOptionalParameter("page_size", pageSize?.ToString()) 
                .AddOptionalParameter("model", model) 
                .AddOptionalParameter("created_after", createdAfter?.ToString("yyyy-MM-ddTHH:mm:ssZ")) 
                .AddOptionalParameter("created_by_me", createdByMe?.ToString()) 
                .AddOptionalParameter("status", status?.ToValueString()) 
                .AddOptionalParameter("wandb_project", wandbProject) 
                .AddOptionalParameter("wandb_name", wandbName) 
                .AddOptionalParameter("suffix", suffix) 
                ; 
            var __path = __pathBuilder.ToString();
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));

            foreach (var _authorization in _authorizations)
            {
                if (_authorization.Type == "Http" ||
                    _authorization.Type == "OAuth2")
                {
                    httpRequest.Headers.Authorization = new global::System.Net.Http.Headers.AuthenticationHeaderValue(
                        scheme: _authorization.Name,
                        parameter: _authorization.Value);
                }
                else if (_authorization.Type == "ApiKey" &&
                         _authorization.Location == "Header")
                {
                    httpRequest.Headers.Add(_authorization.Name, _authorization.Value);
                }
            }

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareGetFineTuningJobsRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                page: page,
                pageSize: pageSize,
                model: model,
                createdAfter: createdAfter,
                createdByMe: createdByMe,
                status: status,
                wandbProject: wandbProject,
                wandbName: wandbName,
                suffix: suffix);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessGetFineTuningJobsResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessGetFineTuningJobsResponseContent(
                httpClient: _httpClient,
                httpResponseMessage: response,
                content: ref __content);

            try
            {
                response.EnsureSuccessStatusCode();
            }
            catch (global::System.Net.Http.HttpRequestException ex)
            {
                throw new global::System.InvalidOperationException(__content, ex);
            }

            return
                global::Mistral.JobsOut.FromJson(__content, JsonSerializerContext) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}