
#nullable enable

namespace Mistral
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BatchExecutionBody
    {
        /// <summary>
        /// List of execution IDs to process
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("execution_ids")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> ExecutionIds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchExecutionBody" /> class.
        /// </summary>
        /// <param name="executionIds">
        /// List of execution IDs to process
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BatchExecutionBody(
            global::System.Collections.Generic.IList<string> executionIds)
        {
            this.ExecutionIds = executionIds ?? throw new global::System.ArgumentNullException(nameof(executionIds));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchExecutionBody" /> class.
        /// </summary>
        public BatchExecutionBody()
        {
        }
    }
}