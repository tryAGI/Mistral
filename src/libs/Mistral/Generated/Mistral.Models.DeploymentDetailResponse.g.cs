
#nullable enable

namespace Mistral
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DeploymentDetailResponse
    {
        /// <summary>
        /// Unique identifier of the deployment
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid Id { get; set; }

        /// <summary>
        /// Deployment name
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Whether at least one worker is currently live
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_active")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsActive { get; set; }

        /// <summary>
        /// When the deployment was first registered
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// When the deployment was last updated
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// Workers registered for the deployment
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workers")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Mistral.DeploymentWorkerResponse> Workers { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeploymentDetailResponse" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier of the deployment
        /// </param>
        /// <param name="name">
        /// Deployment name
        /// </param>
        /// <param name="isActive">
        /// Whether at least one worker is currently live
        /// </param>
        /// <param name="createdAt">
        /// When the deployment was first registered
        /// </param>
        /// <param name="updatedAt">
        /// When the deployment was last updated
        /// </param>
        /// <param name="workers">
        /// Workers registered for the deployment
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeploymentDetailResponse(
            global::System.Guid id,
            string name,
            bool isActive,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            global::System.Collections.Generic.IList<global::Mistral.DeploymentWorkerResponse> workers)
        {
            this.Id = id;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.IsActive = isActive;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.Workers = workers ?? throw new global::System.ArgumentNullException(nameof(workers));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeploymentDetailResponse" /> class.
        /// </summary>
        public DeploymentDetailResponse()
        {
        }
    }
}