
#nullable enable

namespace Mistral
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateWorkflowResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("update_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UpdateName { get; set; }

        /// <summary>
        /// The result of the Update workflow call
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("result")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Result { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateWorkflowResponse" /> class.
        /// </summary>
        /// <param name="updateName"></param>
        /// <param name="result">
        /// The result of the Update workflow call
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateWorkflowResponse(
            string updateName,
            object result)
        {
            this.UpdateName = updateName ?? throw new global::System.ArgumentNullException(nameof(updateName));
            this.Result = result ?? throw new global::System.ArgumentNullException(nameof(result));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateWorkflowResponse" /> class.
        /// </summary>
        public UpdateWorkflowResponse()
        {
        }
    }
}