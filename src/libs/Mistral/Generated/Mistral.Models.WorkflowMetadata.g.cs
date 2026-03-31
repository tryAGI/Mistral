
#nullable enable

namespace Mistral
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WorkflowMetadata
    {
        /// <summary>
        /// Namespace for shared workflows, None if user-owned
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("shared_namespace")]
        public string? SharedNamespace { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowMetadata" /> class.
        /// </summary>
        /// <param name="sharedNamespace">
        /// Namespace for shared workflows, None if user-owned
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WorkflowMetadata(
            string? sharedNamespace)
        {
            this.SharedNamespace = sharedNamespace;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowMetadata" /> class.
        /// </summary>
        public WorkflowMetadata()
        {
        }
    }
}