
#nullable enable

namespace Mistral
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BatchExecutionResponse
    {
        /// <summary>
        /// Mapping of execution_id to result with status and optional error message
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("results")]
        public global::System.Collections.Generic.Dictionary<string, global::Mistral.BatchExecutionResult>? Results { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchExecutionResponse" /> class.
        /// </summary>
        /// <param name="results">
        /// Mapping of execution_id to result with status and optional error message
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BatchExecutionResponse(
            global::System.Collections.Generic.Dictionary<string, global::Mistral.BatchExecutionResult>? results)
        {
            this.Results = results;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchExecutionResponse" /> class.
        /// </summary>
        public BatchExecutionResponse()
        {
        }
    }
}