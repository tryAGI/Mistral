
#nullable enable

namespace Mistral
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class QueryWorkflowResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("query_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string QueryName { get; set; }

        /// <summary>
        /// The result of the Query workflow call
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
        /// Initializes a new instance of the <see cref="QueryWorkflowResponse" /> class.
        /// </summary>
        /// <param name="queryName"></param>
        /// <param name="result">
        /// The result of the Query workflow call
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public QueryWorkflowResponse(
            string queryName,
            object result)
        {
            this.QueryName = queryName ?? throw new global::System.ArgumentNullException(nameof(queryName));
            this.Result = result ?? throw new global::System.ArgumentNullException(nameof(result));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="QueryWorkflowResponse" /> class.
        /// </summary>
        public QueryWorkflowResponse()
        {
        }
    }
}