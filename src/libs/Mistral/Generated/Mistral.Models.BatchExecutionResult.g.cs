
#nullable enable

namespace Mistral
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BatchExecutionResult
    {
        /// <summary>
        /// Status of the operation (success/failure)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Status { get; set; }

        /// <summary>
        /// Error message if operation failed
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        public string? Error { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchExecutionResult" /> class.
        /// </summary>
        /// <param name="status">
        /// Status of the operation (success/failure)
        /// </param>
        /// <param name="error">
        /// Error message if operation failed
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BatchExecutionResult(
            string status,
            string? error)
        {
            this.Status = status ?? throw new global::System.ArgumentNullException(nameof(status));
            this.Error = error;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchExecutionResult" /> class.
        /// </summary>
        public BatchExecutionResult()
        {
        }
    }
}