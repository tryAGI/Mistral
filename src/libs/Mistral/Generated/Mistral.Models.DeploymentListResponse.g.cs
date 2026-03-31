
#nullable enable

namespace Mistral
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DeploymentListResponse
    {
        /// <summary>
        /// List of deployments
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deployments")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Mistral.DeploymentResponse> Deployments { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeploymentListResponse" /> class.
        /// </summary>
        /// <param name="deployments">
        /// List of deployments
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeploymentListResponse(
            global::System.Collections.Generic.IList<global::Mistral.DeploymentResponse> deployments)
        {
            this.Deployments = deployments ?? throw new global::System.ArgumentNullException(nameof(deployments));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeploymentListResponse" /> class.
        /// </summary>
        public DeploymentListResponse()
        {
        }
    }
}