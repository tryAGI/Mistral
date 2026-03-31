
#nullable enable

namespace Mistral
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WorkflowExecutionListResponse
    {
        /// <summary>
        /// A list of workflow executions
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("executions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Mistral.WorkflowExecutionWithoutResultResponse> Executions { get; set; }

        /// <summary>
        /// Token to use for fetching the next page of results. Null if this is the last page.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("next_page_token")]
        public string? NextPageToken { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowExecutionListResponse" /> class.
        /// </summary>
        /// <param name="executions">
        /// A list of workflow executions
        /// </param>
        /// <param name="nextPageToken">
        /// Token to use for fetching the next page of results. Null if this is the last page.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WorkflowExecutionListResponse(
            global::System.Collections.Generic.IList<global::Mistral.WorkflowExecutionWithoutResultResponse> executions,
            string? nextPageToken)
        {
            this.Executions = executions ?? throw new global::System.ArgumentNullException(nameof(executions));
            this.NextPageToken = nextPageToken;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowExecutionListResponse" /> class.
        /// </summary>
        public WorkflowExecutionListResponse()
        {
        }
    }
}