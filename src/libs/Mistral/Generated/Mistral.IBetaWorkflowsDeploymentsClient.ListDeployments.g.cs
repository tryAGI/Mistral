#nullable enable

namespace Mistral
{
    public partial interface IBetaWorkflowsDeploymentsClient
    {
        /// <summary>
        /// List Deployments
        /// </summary>
        /// <param name="activeOnly">
        /// Default Value: true
        /// </param>
        /// <param name="workflowName"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mistral.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Mistral.DeploymentListResponse> ListDeploymentsAsync(
            bool? activeOnly = default,
            string? workflowName = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}