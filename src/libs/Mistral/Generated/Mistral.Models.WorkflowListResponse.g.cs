
#nullable enable

namespace Mistral
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WorkflowListResponse
    {
        /// <summary>
        /// A list of workflows
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workflows")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Mistral.WorkflowBasicDefinition> Workflows { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("next_cursor")]
        public global::System.Guid? NextCursor { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowListResponse" /> class.
        /// </summary>
        /// <param name="workflows">
        /// A list of workflows
        /// </param>
        /// <param name="nextCursor"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WorkflowListResponse(
            global::System.Collections.Generic.IList<global::Mistral.WorkflowBasicDefinition> workflows,
            global::System.Guid? nextCursor)
        {
            this.Workflows = workflows ?? throw new global::System.ArgumentNullException(nameof(workflows));
            this.NextCursor = nextCursor;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowListResponse" /> class.
        /// </summary>
        public WorkflowListResponse()
        {
        }
    }
}