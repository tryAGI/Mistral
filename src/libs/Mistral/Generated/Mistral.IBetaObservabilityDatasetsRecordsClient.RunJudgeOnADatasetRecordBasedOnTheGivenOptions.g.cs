#nullable enable

namespace Mistral
{
    public partial interface IBetaObservabilityDatasetsRecordsClient
    {
        /// <summary>
        /// Run Judge on a dataset record based on the given options
        /// </summary>
        /// <param name="datasetRecordId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mistral.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Mistral.JudgeOutput> RunJudgeOnADatasetRecordBasedOnTheGivenOptionsAsync(
            global::System.Guid datasetRecordId,

            global::Mistral.PostDatasetRecordJudgingInSchema request,
            global::Mistral.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Run Judge on a dataset record based on the given options
        /// </summary>
        /// <param name="datasetRecordId"></param>
        /// <param name="judgeDefinition"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Mistral.JudgeOutput> RunJudgeOnADatasetRecordBasedOnTheGivenOptionsAsync(
            global::System.Guid datasetRecordId,
            global::Mistral.PostJudgeInSchema judgeDefinition,
            global::Mistral.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}