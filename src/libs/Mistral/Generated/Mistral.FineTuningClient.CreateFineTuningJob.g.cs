
#nullable enable

namespace Mistral
{
    public partial class FineTuningClient
    {
        partial void PrepareCreateFineTuningJobArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref bool? dryRun,
            global::Mistral.JobIn request);
        partial void PrepareCreateFineTuningJobRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            bool? dryRun,
            global::Mistral.JobIn request);
        partial void ProcessCreateFineTuningJobResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessCreateFineTuningJobResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Create Fine Tuning Job<br/>
        /// Create a new fine-tuning job, it will be queued for processing.
        /// </summary>
        /// <param name="dryRun"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::Mistral.AnyOf<global::Mistral.JobOut, global::Mistral.LegacyJobMetadataOut>> CreateFineTuningJobAsync(
            global::Mistral.JobIn request,
            bool? dryRun = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: _httpClient);
            PrepareCreateFineTuningJobArguments(
                httpClient: _httpClient,
                dryRun: ref dryRun,
                request: request);

            var __pathBuilder = new PathBuilder(
                path: "/v1/fine_tuning/jobs",
                baseUri: _httpClient.BaseAddress); 
            __pathBuilder 
                .AddOptionalParameter("dry_run", dryRun?.ToString()) 
                ; 
            var __path = __pathBuilder.ToString();
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
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
            var __httpRequestContentBody = global::System.Text.Json.JsonSerializer.Serialize(request, request.GetType(), JsonSerializerContext);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareCreateFineTuningJobRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                dryRun: dryRun,
                request: request);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessCreateFineTuningJobResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessCreateFineTuningJobResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize(__content, typeof(global::Mistral.AnyOf<global::Mistral.JobOut, global::Mistral.LegacyJobMetadataOut>?), JsonSerializerContext) as global::Mistral.AnyOf<global::Mistral.JobOut, global::Mistral.LegacyJobMetadataOut>? ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Create Fine Tuning Job<br/>
        /// Create a new fine-tuning job, it will be queued for processing.
        /// </summary>
        /// <param name="dryRun"></param>
        /// <param name="autoStart">
        /// This field will be required in a future release.
        /// </param>
        /// <param name="hyperparameters">
        /// The fine-tuning hyperparameter settings used in a fine-tune job.
        /// </param>
        /// <param name="integrations">
        /// A list of integrations to enable for your fine-tuning job.
        /// </param>
        /// <param name="model">
        /// The name of the model to fine-tune.
        /// </param>
        /// <param name="repositories">
        /// Default Value: []
        /// </param>
        /// <param name="suffix">
        /// A string that will be added to your fine-tuning model name. For example, a suffix of "my-great-model" would produce a model name like `ft:open-mistral-7b:my-great-model:xxx...`
        /// </param>
        /// <param name="trainingFiles">
        /// Default Value: []
        /// </param>
        /// <param name="validationFiles">
        /// A list containing the IDs of uploaded files that contain validation data. If you provide these files, the data is used to generate validation metrics periodically during fine-tuning. These metrics can be viewed in `checkpoints` when getting the status of a running fine-tuning job. The same data should not be present in both train and validation files.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::Mistral.AnyOf<global::Mistral.JobOut, global::Mistral.LegacyJobMetadataOut>> CreateFineTuningJobAsync(
            global::Mistral.TrainingParametersIn hyperparameters,
            global::Mistral.FineTuneableModel model,
            bool? dryRun = default,
            bool? autoStart = default,
            global::System.Collections.Generic.IList<global::Mistral.OneOf<global::Mistral.WandbIntegration>>? integrations = default,
            global::System.Collections.Generic.IList<global::Mistral.OneOf<global::Mistral.GithubRepositoryIn>>? repositories = default,
            string? suffix = default,
            global::System.Collections.Generic.IList<global::Mistral.TrainingFile>? trainingFiles = default,
            global::System.Collections.Generic.IList<global::System.Guid>? validationFiles = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::Mistral.JobIn
            {
                AutoStart = autoStart,
                Hyperparameters = hyperparameters,
                Integrations = integrations,
                Model = model,
                Repositories = repositories,
                Suffix = suffix,
                TrainingFiles = trainingFiles,
                ValidationFiles = validationFiles,
            };

            return await CreateFineTuningJobAsync(
                dryRun: dryRun,
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}