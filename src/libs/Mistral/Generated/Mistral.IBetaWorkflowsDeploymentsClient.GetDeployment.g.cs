#nullable enable

namespace Mistral
{
    public partial interface IBetaWorkflowsDeploymentsClient
    {
        /// <summary>
        /// Get Deployment
        /// </summary>
        /// <param name="name"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Mistral.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Mistral.DeploymentDetailResponse> GetDeploymentAsync(
            string name,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}